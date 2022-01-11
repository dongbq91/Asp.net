using Bai13_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai13_BookStore.Controllers
{
    public class BookStoreController : Controller
    {
        // GET: BookStore
        ShopSachDB db = new ShopSachDB();
        private List<SACH> Laysachmoi(int count)
        {
            return db.SACHes.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var sachmoi = Laysachmoi(5);
            return View(sachmoi);
        }
      
        public ActionResult Details(int id)
        {
            var sach = from s in db.SACHes where s.Masach == id select s;
            return View(sach.Single());
        }
    }
}