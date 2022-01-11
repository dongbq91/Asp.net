using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai15.Models;

namespace Bai15.Controllers
{
    public class TheloaitinController : Controller
    {
        // GET: Theloaitin\
        QLTintucDB db = new QLTintucDB();
        public ActionResult Index()
        {
            var All_Loaitin = from tt in db.Theloaitins select tt;
            return View(All_Loaitin);
        }
        public ActionResult Details(int id)
        {
            var Details_tin = db.Theloaitins.Where(m => m.IDLoai == id).First();
            return View(Details_tin);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection , Theloaitin ltin)
        {
            var CB_Loaitin = collection["Tentheloai"];
            if (string.IsNullOrEmpty(CB_Loaitin))
            {
                ViewData["Loi"] = "The loai nay khong duoc de trong";
            }
            else
            {
                ltin.Tentheloai = CB_Loaitin;

                db.Theloaitins.Add(ltin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Edit(int id)
        {
            var EB_tin = db.Theloaitins.First(m => m.IDLoai == id);
            return View(EB_tin);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var Ltin = db.Theloaitins.First(m => m.IDLoai == id);
            var E_Loaitin = collection["Tentheloai"];
            Ltin.IDLoai = id;
            if (string.IsNullOrEmpty(E_Loaitin))
            {
                ViewData["Loi"] = "The loai tin khong duoc bo trong";
            }
            else
            {
                Ltin.Tentheloai = E_Loaitin;
                UpdateModel(Ltin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }

        public ActionResult Delete(int id)
        {
            var D_tin = db.Theloaitins.Where(m => m.IDLoai == id).First();
            return View(D_tin);
        }
        [HttpPost]
        public ActionResult Delete(int id , FormCollection collection)
        {
            var D_tin = db.Theloaitins.Where(m => m.IDLoai == id).First();
            try
            {
                db.Theloaitins.Remove(D_tin);
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