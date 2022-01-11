using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai5.Models;

namespace Bai5.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(SinhVien sv)
        {
            String path = Server.MapPath("~/student.txt");
            string[] lines = { sv.Id, sv.Name, sv.Diem.ToString() };
            System.IO.File.WriteAllLines(path, lines);
            ViewBag.HanhDong = "Da gi file!";
            return View("Index");
        }
        public ActionResult Open(SinhVien sv)
        {
            String path = Server.MapPath("~/student.txt");
            string[] lines = System.IO.File.ReadAllLines(path);
            sv.Id = lines[0];
            sv.Name = lines[1];
            sv.Diem = Convert.ToDouble(lines[2]);
            ViewBag.ThongTin = "Ma sinh vien :" + sv.Id + "- Ho ten : " + sv.Name + "- Diem :" + sv.Diem;
            ViewBag.HanhDong = "Da doc tu file!";
            return View("Index");
        }
    }
}