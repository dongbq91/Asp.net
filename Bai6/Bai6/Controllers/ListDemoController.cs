using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai6.Controllers
{
    public class ListDemoController : Controller
    {
        // GET: ListDemo
        public ActionResult Bullets()
        {
            return View();
        }
        public ActionResult Numberring()
        {
            return View();
        }
    }
}