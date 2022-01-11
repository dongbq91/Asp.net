using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BachQuocDong_2018604425_De2.Models;

namespace BachQuocDong_2018604425_De2.Controllers
{
    public class HoSoesController : Controller
    {
        private BachQuocDong db = new BachQuocDong();

        // GET: HoSoes
        
        public ActionResult Index(int? num1, int? num2)
        {
            if (num1 != null && num2 != null)
            {
                double tong = 0;
                var nv = db.HoSoes.Where(n => n.Bacluong >= num1 && n.Bacluong <= num2).ToList();
                foreach (var a in nv)
                {
                    tong += (double)a.Bacluong *1300000;
                }
                ViewBag.t = "Tổng lương";
                ViewBag.tong = tong;
                return View(nv);
            }
            else
                return View(db.HoSoes.ToList());
        }

        // GET: HoSoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoSo hoSo = db.HoSoes.Find(id);
            if (hoSo == null)
            {
                return HttpNotFound();
            }
            return View(hoSo);
        }

        // GET: HoSoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HoSoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mahs,Hoten,Donvi,Bacluong")] HoSo hoSo)
        {
            if (ModelState.IsValid)
            {
                db.HoSoes.Add(hoSo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hoSo);
        }

        // GET: HoSoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoSo hoSo = db.HoSoes.Find(id);
            if (hoSo == null)
            {
                return HttpNotFound();
            }
            return View(hoSo);
        }

        // POST: HoSoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mahs,Hoten,Donvi,Bacluong")] HoSo hoSo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoSo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hoSo);
        }

        // GET: HoSoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoSo hoSo = db.HoSoes.Find(id);
            if (hoSo == null)
            {
                return HttpNotFound();
            }
            return View(hoSo);
        }

        // POST: HoSoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HoSo hoSo = db.HoSoes.Find(id);
            db.HoSoes.Remove(hoSo);
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
