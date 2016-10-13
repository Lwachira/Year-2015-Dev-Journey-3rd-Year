using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using AngularStoredProc.Models;

namespace AngularStoredProc.Controllers.HomeController
{
    public class HomeController : Controller
    {
        readonly SprocEntities _db = new SprocEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}