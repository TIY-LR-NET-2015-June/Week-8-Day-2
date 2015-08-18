using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Week8.Day2_HW.Models;

namespace Week8.Day2_HW.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new RestClient();
            var keystring = WebConfigurationManager.AppSettings["MyEtsyKey"];
            client.BaseUrl = new Uri("https://openapi.etsy.com/v2");

            var request = new RestRequest("/listings/active");
            request.Method = Method.GET;
            request.AddParameter("limit", 10);
            request.AddParameter("includes", "MainImage");
            request.AddParameter("api_key", keystring);

            var response = client.Execute<RootObject>(request);
            return View(response.Data.results);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}