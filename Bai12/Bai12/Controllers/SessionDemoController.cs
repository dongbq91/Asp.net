using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai12.Controllers
{
    public class SessionDemoController : Controller
    {
        // GET: SessionDemo
        public ActionResult Index()
        {
            if(Session["count"]== null)
            {
                Session["count"] = 0;
            }
            int c = (int)Session["count"];
            c++;
            Session["count"] = c;
            return View();
        }
    }
}