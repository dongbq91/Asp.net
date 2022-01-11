using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        /*public ActionResult Index()
        {
            return View();
        }*/
        public string Index()
        {
            return "Đây là phương thức index , phương thức mặc định của Controller";
        }
        public String ChaoMung1()
        {
            return "Đây là phương thức Chào mừng trong Controller Hello";
        }
        public String Chaomungtiep(string ten, int solan = 1)
        {
            return HttpUtility.HtmlEncode("Xin chào : " + ten + ". Số lần là : " + solan);
        }
        public String Chaomung3(string ten, int id = 1)
        {
            return HttpUtility.HtmlEncode("Xin chào : " + ten + ". ID : " + id);
        }
    }
}