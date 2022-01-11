using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using De1.Models;

namespace De1.Controllers
{
    public class NhanvienController : Controller
    {
        DBDe1 db = new DBDe1();
        // GET: Nhanvien
        public ActionResult Index( string sortnv , string seachnv ,  string currenFilter, int? page)
        {
            var all_nhanvien = from tt in db.NhanViens select tt;
            ViewBag.Sapnv = String.IsNullOrEmpty(sortnv) ? "name_nv" : "";
            var nhanvien = db.NhanViens.Select(p => p);
            
            if (!String.IsNullOrEmpty(seachnv))
            {
                nhanvien = nhanvien.Where(p => p.Hoten.Contains(seachnv));
            }

            switch (sortnv)
            {
                case "name_nv":
                    nhanvien = nhanvien.OrderByDescending(s => s.Hoten);
                    break;
                default:
                    nhanvien = nhanvien.OrderBy(s => s.Hoten);
                    break;
            }
            
            return View(nhanvien.ToList());
        }
        public ActionResult Details(String id)
        {
            var Details_nv = db.NhanViens.Where(m => m.Manv == id).First();
            return View(Details_nv);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection f , NhanVien nv)
        {
            var cr_id = f["Manv"];
            var cr_ht = f["Hoten"];
            var cr_phong = f["Phong"];
            var cr_luong = f["Luong"];
            if (string.IsNullOrEmpty(cr_ht))
            {
                ViewData["LoiHoten"] = "Ho ten khong duoc de trong";
            }
            else if(string.IsNullOrEmpty(cr_id))
            {
                ViewData["LoiID"] = "ID khong duoc de trong";
            }
            else if (string.IsNullOrEmpty(cr_phong))
            {
                ViewData["LoiPhong"] = "Phong khong duoc de trong";
            }
            else if (string.IsNullOrEmpty(cr_luong))
            {
                ViewData["LoiLuong"] = "Lương khong duoc de trong";
            }

            else
            {

                nv.Hoten = cr_ht;
                nv.Manv = cr_id;
                nv.Phong = cr_phong;
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        public ActionResult Edit(String id)
        {
            var ed_nv = db.NhanViens.Where(m => m.Manv == id).First();

            return View(ed_nv);
        }
        [HttpPost]
        public ActionResult Edit( FormCollection f , String id)
        {
            var IDnv = db.NhanViens.First(m => m.Manv == id);

            var cr_id = f["Manv"];
            var cr_ht = f["Hoten"];
            var cr_phong = f["Phong"];
            var cr_luong = f["Luong"];
            if (string.IsNullOrEmpty(cr_ht))
            {
                ViewData["LoiHoten"] = "Ho ten khong duoc de trong";
            }
            else if (string.IsNullOrEmpty(cr_id))
            {
                ViewData["LoiID"] = "ID khong duoc de trong";
            }
            else if (string.IsNullOrEmpty(cr_phong))
            {
                ViewData["LoiPhong"] = "Phong khong duoc de trong";
            }
            else if (string.IsNullOrEmpty(cr_luong))
            {
                ViewData["LoiLuong"] = "Lương khong duoc de trong";
            }
            else
            {
                IDnv.Manv = cr_id;
                UpdateModel(IDnv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }

        public ActionResult Delete(String id)
        {
            var D_nv = db.NhanViens.Where(m => m.Manv == id).First();
            
            return View(D_nv);
        }
        [HttpPost]
        public ActionResult Delete (FormCollection f , String id)
        {
            var D_nv = db.NhanViens.Where(m => m.Manv == id).First();
            try
            {
                db.NhanViens.Remove(D_nv);
                db.SaveChanges();
            }
            catch
            {
                ViewData["Loi"] = " Khong xoa duoc";
                return this.Delete(id);
            }
            return RedirectToAction("Index");
        }
    }
}