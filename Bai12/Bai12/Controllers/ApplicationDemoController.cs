using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai12.Controllers
{
    public class ApplicationDemoController : Controller
    {
        // GET: ApplicationDemo
        public ActionResult Index()
        {
            if(HttpContext.Application["count"]== null)
            {
                HttpContext.Application["count"] = 0;
            }
            int c = (int)HttpContext.Application["count"];
            c++;
            HttpContext.Application["count"] = c;
            ViewBag.app = c;
            return View();
        }
    }
}