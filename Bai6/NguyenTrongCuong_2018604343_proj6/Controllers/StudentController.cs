using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenTrongCuong_2018604343_proj7.Models;

namespace NguyenTrongCuong_2018604343_proj7.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(Student s)
        {
            return View(s);
        }
        public ActionResult Regis2(FormCollection f)
        {
            Student s = new Student();
            s.name = f["name"];
            s.gender = f["gender"];
            s.email = f["email"];
            s.addr = f["addr"];
            // check box 

            string strtemp = "";
            if (f["Toan"] == "true,false")
                strtemp = "Toan";
            if (f["Ly"] == "true,false")
                strtemp += " " + "Ly";
            if (f["Hoa"] == "true,false")
                strtemp += " " + "Hoa";

            s.subject = strtemp;
            s.username = f["username"];
            s.password = f["password"];
            s.comment = f["commment"];
            return View("Regis", s);
        }
    }
}