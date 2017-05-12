using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XploreWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View("Index", "_Layout");
        }

        public ActionResult About()
        {

            return View("About", "_Layout");
        }

        public ActionResult Contact()
        {

            return View("Contact", "_Layout");
        }
    }
}
