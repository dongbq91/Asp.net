using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BachQuocDong_2018604425_De2.Models;

namespace BachQuocDong_2018604425_De2.Controllers
{
    public class Cau5Controller : Controller
    {
        // GET: Cau5
        BachQuocDong db = new BachQuocDong();
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fr, HoSo hs)
        {
            hs = new HoSo();
            hs.Mahs = fr["manv"];
            var check = db.HoSoes.FirstOrDefault(x => x.Mahs == hs.Mahs);
            if (check != null)
            {
                ViewBag.msg = "Trùng mã nhân viên";
                return View("Index");
            }
            else
            {
                hs.Hoten = fr["hoten"];
                hs.Donvi = fr["phong"];
                hs.Bacluong = double.Parse(fr["luong"]);

                db.HoSoes.Add(hs);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "NhanViens");
        }
    }
}