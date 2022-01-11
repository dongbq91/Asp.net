using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai15.Models;

namespace Bai15.Controllers
{
    public class TintucController : Controller
    {
        // GET: Tintuc
        QLTintucDB db = new QLTintucDB();
        public ActionResult Index()
        {
            var All_Tintuc = from tt in db.Tintucs select tt;
            var load_tin = from tt in db.Theloaitins select tt;
            List<Theloaitin> items = load_tin.ToList();
            ViewBag.IDLoais = items;
            //var select = from tt in db.Theloaitins.Where(m => m.Tentheloai == ten).First();
            return View(All_Tintuc);
        }
        public ActionResult Details(int id)
        {
            var Details_tintuc = db.Tintucs.Where(m => m.IdTin == id).First();
            return View(Details_tintuc);
        }
        public ActionResult Create()
        {
            var load_tin = from tt in db.Theloaitins select tt;
            List<Theloaitin> items = load_tin.ToList();
            ViewBag.IDLoais = items;
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, Tintuc ltin)
        {
            var CB_Loaitintuc = collection["Tieudetin"];
            if (string.IsNullOrEmpty(CB_Loaitintuc))
            {
                ViewData["Loi"] = "Tieu de khong duoc de trong";
            }
            else
            {
                ltin.Tieudetin = CB_Loaitintuc;

                db.Tintucs.Add(ltin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Edit(int id)
        {
            var EB_tin = db.Tintucs.First(m => m.IdTin == id);
            var load_tin = from tt in db.Theloaitins select tt;
            List<Theloaitin> items = load_tin.ToList();
            ViewBag.IDLoais = items;
            return View(EB_tin);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var Ltin = db.Tintucs.First(m => m.IdTin == id);
            var E_Loaitin = collection["Tieudetin"];
            Ltin.IdTin = id;
            if (string.IsNullOrEmpty(E_Loaitin))
            {
                ViewData["Loi"] = "The loai tin khong duoc bo trong";
            }
            else
            {
                Ltin.Tieudetin = E_Loaitin;
                UpdateModel(Ltin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }

        public ActionResult Delete(int id)
        {
            var D_tin = db.Tintucs.Where(m => m.IdTin == id).First();
            var load_tin = from tt in db.Theloaitins select tt;
            List<Theloaitin> items = load_tin.ToList();
            ViewBag.IDLoais = items;
            return View(D_tin);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_tin = db.Tintucs.First(m => m.IdTin == id);
            try
            {
            db.Tintucs.Remove(D_tin);
            db.SaveChanges();
            }
            catch
            {
                ViewData["Loi"] = "Khong xoa duoc";
                return this.Delete(id);
            }
            
            return RedirectToAction("Index");
        }

    }
}