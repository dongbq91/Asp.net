using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BachQuocDong_425_16762.Models;

namespace BachQuocDong_425_16762.Controllers
{
    public class Cau4Controller : Controller
    {
        // GET: Cau4
        BachQuocDong db = new BachQuocDong();
        public ActionResult Index()
        {

            var All_Khoa = from tt in db.KhoaKhams select tt;
            return View(All_Khoa);
        }
        public ActionResult Details(String id)
        {
            var Details_khoa = db.KhoaKhams.Where(m => m.Makhoa == id).First();
            return View(Details_khoa);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, KhoaKham khoa)
        {
            var Cr_ma = collection["Makhoa"];
            var Cr_ten = collection["Makhoa"];
            if (string.IsNullOrEmpty(Cr_ma))
            {
                ViewData["LoiID"] = "Mã khoa không được để trống";
            }else if(string.IsNullOrEmpty(Cr_ten))
            {
                ViewData["Loiten"] = "Tên khoa không được để trống";
            }
            else
            {
                khoa.Makhoa = Cr_ma;
                khoa.Tenkhoa = Cr_ten;
                db.KhoaKhams.Add(khoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Delete(String id)
        {
            var D_khoa = db.KhoaKhams.Where(m => m.Makhoa == id).First();
            return View(D_khoa);
        }
        [HttpPost]
        public ActionResult Delete(String id, FormCollection collection)
        {
            var D_khoa = db.KhoaKhams.Where(m => m.Makhoa == id).First();
            try
            {
                db.KhoaKhams.Remove(D_khoa);
                db.SaveChanges();
            }
            catch
            {
                ViewData["Loi xoa"] = "Khong xoa duoc";
                return this.Delete(id);
            }
            return RedirectToAction("Index");
        }
    }
}