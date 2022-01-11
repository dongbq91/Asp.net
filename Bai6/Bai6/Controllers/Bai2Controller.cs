using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai6.Models;

namespace Bai6.Controllers
{
    public class Bai2Controller : Controller
    {
        // GET: Bai2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(bai2 s)
        {
            return View(s);
        }
        public ActionResult Regis2(FormCollection f)
        {
            bai2 s = new bai2();
            s.firstname = f["firstname"];
            s.lastname = f["lastname"];
            s.email = f["email"];
            s.password = f["password"];
            s.addr = f["addr"];
            s.gender = f["gender"];
            return View("Regis", s);
        }
    }
}