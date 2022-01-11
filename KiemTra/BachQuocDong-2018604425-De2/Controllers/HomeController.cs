using BachQuocDong_2018604425_De2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BachQuocDong_2018604425_De2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cau1()
        {
            return View();
        }
        public ActionResult Cau2()
        {
            return View();
        }
        public ActionResult kqCau2()
        {
            return View();
        }
        public ActionResult tinhCau2(FormCollection f)
        {
            string sl = f["sl"];
            string dg = f["dg"];
            float a = float.Parse(sl);
            float b = float.Parse(dg);

            float tien;
           
                tien = (a * b);
           
            sanpham s = new sanpham();
            s.masp = f["masp"];
            s.tensp = f["tensp"];
            s.loaisp = f["loaisp"];
            s.soluong = f["soluong"];
            s.dongia = f["dongia"];
            s.tien = f["tien"];
            return View("kqCau2", s);
            
        }
    }
}