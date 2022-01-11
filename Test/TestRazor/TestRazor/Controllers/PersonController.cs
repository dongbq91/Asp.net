using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRazor.Models;

namespace TestRazor.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(Person p)
        {
            return View(p);
        }
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Save(FormCollection f)
        {
            
            string path = Server.MapPath("~/info.txt");
            string[] info = { f["name"], f["gioitinh"], f["diachi"] };
            System.IO.File.WriteAllLines(path, info);
            return View("Index");

        }
        public ActionResult open()
        {
            string path = Server.MapPath("~/info.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            Person s = new Person();
            s.name = info[0];
            s.gioitinh = info[1];
            s.diachi = info[2];

            return View("Regis",s);
        }
    }
}