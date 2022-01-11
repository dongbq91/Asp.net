using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai12.Controllers
{
    public class LoginDemoController : Controller
    {
        // GET: LoginDemo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckLogin(string username, string password)
        {
            if(username =="admin" && password == "123456")
            {
                Session["user"] = username;
                return RedirectToAction("Index", "Home");
            }
            if(username == "")
            {
                ViewBag.msg = "Phải nhập vào đây";
            }
            else
            {
                ViewBag.msg = "Không hợp lệ";
            }
            return View("Index");
        }
        public ActionResult Logout()
        {
            Session.Remove("user");
            return View("Index");
        }
    }
}