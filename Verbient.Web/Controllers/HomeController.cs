using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Verbient.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A global leader in consulting, technology services and digital transformation, We are at the forefront of innovation to address the entire breadth of clients’ opportunities in the evolving world of cloud, digital and platforms.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Product()
        {
            ViewBag.Message = "Coming Soon";

            return View();
        }
    }
}