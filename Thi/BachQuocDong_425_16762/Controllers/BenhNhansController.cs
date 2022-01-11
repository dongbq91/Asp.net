using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BachQuocDong_425_16762.Models;

namespace BachQuocDong_425_16762.Controllers
{
    public class BenhNhansController : Controller
    {
        private BachQuocDong db = new BachQuocDong();

        // GET: BenhNhans
        public ActionResult Index(string sortbn)
        {
            var benhNhans = db.BenhNhans.Include(b => b.KhoaKham);
            ViewBag.Sapbn = sortbn == "ngay" ? "ngay_des" : "ngay";
            var benhnhan = db.BenhNhans.Select(p => p);
            switch (sortbn)
            {
                case "ngay":
                    benhnhan = benhnhan.OrderBy(s => s.SongayNV);
                    break;
                case "ngay_des":
                    benhnhan = benhnhan.OrderByDescending(s => s.SongayNV);
                    break;
                default:
                    benhnhan = benhnhan.OrderBy(s => s.SongayNV);
                    break;
            }
            return View(benhNhans.ToList());
        }

        // GET: BenhNhans/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            if (benhNhan == null)
            {
                return HttpNotFound();
            }
            return View(benhNhan);
        }

        // GET: BenhNhans/Create
        public ActionResult Create()
        {
            ViewBag.Makhoa = new SelectList(db.KhoaKhams, "Makhoa", "Tenkhoa");
            return View();
        }

        // POST: BenhNhans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mabn,Hoten,Diachi,SongayNV,Makhoa")] BenhNhan benhNhan)
        {
            if (ModelState.IsValid)
            {
                db.BenhNhans.Add(benhNhan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Makhoa = new SelectList(db.KhoaKhams, "Makhoa", "Tenkhoa", benhNhan.Makhoa);
            return View(benhNhan);
        }

        // GET: BenhNhans/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            if (benhNhan == null)
            {
                return HttpNotFound();
            }
            ViewBag.Makhoa = new SelectList(db.KhoaKhams, "Makhoa", "Tenkhoa", benhNhan.Makhoa);
            return View(benhNhan);
        }

        // POST: BenhNhans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mabn,Hoten,Diachi,SongayNV,Makhoa")] BenhNhan benhNhan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(benhNhan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Makhoa = new SelectList(db.KhoaKhams, "Makhoa", "Tenkhoa", benhNhan.Makhoa);
            return View(benhNhan);
        }

        // GET: BenhNhans/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            if (benhNhan == null)
            {
                return HttpNotFound();
            }
            return View(benhNhan);
        }

        // POST: BenhNhans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BenhNhan benhNhan = db.BenhNhans.Find(id);
            db.BenhNhans.Remove(benhNhan);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
