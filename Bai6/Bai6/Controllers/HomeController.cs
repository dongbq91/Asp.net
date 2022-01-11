using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My Layout.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "https://sv.dhcnhn.vn/";

            return View();
        }
    }
}