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
    public class KhoaKhamsController : Controller
    {
        private BachQuocDong db = new BachQuocDong();

        // GET: KhoaKhams
        public ActionResult Index()
        {
            return View(db.KhoaKhams.ToList());
        }

        // GET: KhoaKhams/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaKham khoaKham = db.KhoaKhams.Find(id);
            if (khoaKham == null)
            {
                return HttpNotFound();
            }
            return View(khoaKham);
        }

        // GET: KhoaKhams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhoaKhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Makhoa,Tenkhoa")] KhoaKham khoaKham)
        {
            if (ModelState.IsValid)
            {
                db.KhoaKhams.Add(khoaKham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khoaKham);
        }

        // GET: KhoaKhams/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaKham khoaKham = db.KhoaKhams.Find(id);
            if (khoaKham == null)
            {
                return HttpNotFound();
            }
            return View(khoaKham);
        }

        // POST: KhoaKhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Makhoa,Tenkhoa")] KhoaKham khoaKham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoaKham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khoaKham);
        }

        // GET: KhoaKhams/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaKham khoaKham = db.KhoaKhams.Find(id);
            if (khoaKham == null)
            {
                return HttpNotFound();
            }
            return View(khoaKham);
        }

        // POST: KhoaKhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KhoaKham khoaKham = db.KhoaKhams.Find(id);
            db.KhoaKhams.Remove(khoaKham);
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
