using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaculateAplication.Models;
namespace CaculateAplication.Controllers
{
    public class TinhController : Controller
    {
        // GET: Caculate
        public ActionResult Index(Diem diem, FormCollection frm, string Tinh)
        {
            switch (Tinh)
            {
                case "cong": 
                    ViewBag.diem = diem.SoA + diem.SoB;
                    break;
                case "tru":
                    ViewBag.diem = diem.SoA - diem.SoB;
                    break;
                case "nhan":
                    ViewBag.diem = diem.SoA * diem.SoB;
                    break;
                case "chia":
                    ViewBag.diem = diem.SoA / diem.SoB;
                    break;
            }
            return View();
        }
    }
}