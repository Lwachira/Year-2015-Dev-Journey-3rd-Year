﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View(); 
        }

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        ////public string Welcome()
        ////{
        ////    return "This is the welcome action method";
        ////}

        //public string Welcome(string name,int ID = 1)
        //{
        //    return HtmlEncoder.Default.HtmlEncode("Hello " + name + ", ID is: " + ID);
        //}
    }
}
