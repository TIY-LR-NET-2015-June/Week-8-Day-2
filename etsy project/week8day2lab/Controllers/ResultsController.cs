using MikesEtsyProject.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MikesEtsyProject.Controllers
{
    public class EtsyResultsController : Controller
    {
        // GET: EtsyResults
        public ActionResult Index()
        {
            var client = new RestClient("https://openapi.etsy.com/v2/listings/active");//?limit=10&offset=0&includes=MainImage&api_key=bns97cj33kxh8iucx0xni9ri");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest(Method.GET);
            request.AddParameter("limit", "10"); // adds to POST or URL querystring based on Method
            request.AddParameter("offset", 0);
            request.AddParameter("includes", "MainImage"); // adds to POST or URL querystring based on Method
            request.AddParameter("api_key", "bns97cj33kxh8iucx0xni9ri");

            // easily add HTTP Headers

            // add files to upload (works with compatible verbs)

            // execute the request
            IRestResponse response1 = client.Execute(request);
            var content = response1.Content; // raw content as string

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            var response2 = client.Execute<RootObject>(request);
            var name = response2.Data.results;
            System.Web.HttpContext.Current.Session["data"] = response2;
            // easy async support
            //client.ExecuteAsync(request, response => {
            //Console.WriteLine(response.Content);
            //});

            //// async with deserialization
            //var asyncHandle = client.ExecuteAsync<Person>(request, response => {
            //Console.WriteLine(response.Data.Name);
            //});

            //// abort the request on demand
            //asyncHandle.Abort();
            return View(name);
        }
        //get the image















































































    }
}
