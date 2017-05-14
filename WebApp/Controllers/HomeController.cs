using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("Home/Section1/")]

        public ActionResult Section1Index()
        {
            return View("Section1/Index");
        }

        [Route("Home/Section2/")]

        public ActionResult Section2Index()
        {
            return View("Section2/Index");
        }

        [Route("Home/Section3/")]

        public ActionResult Section3Index()
        {
            return View("Section3/Index");
        }
    }
}