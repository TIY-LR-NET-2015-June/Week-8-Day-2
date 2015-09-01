﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace week8day2Homework.Controllers
{
    public class HomeController : Controller
    {
        private static void Main(string[] args)
        {
            var key = ConfigurationManager.AppSettings["myEtsyKey"];
        }


        public ActionResult Index()
        {
            return View();
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
