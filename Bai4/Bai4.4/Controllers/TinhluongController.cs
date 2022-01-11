using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4._4.Models;

namespace Bai4._4.Controllers
{
    public class TinhluongController : Controller
    {
        // GET: Tinhluong
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Luongve(Nhanvien nv , FormCollection data)
        {
            int tienLinh;
            int nctl = nv.NgayCong;
            int phuCap = 0;
            if (nv.NgayCong >= 25)
            {
                nctl = (nv.NgayCong - 25) * 2 + 25;
            }
            string chucvu = data["chucvu"];
            if (chucvu.ToString() == "tp")
            {
                phuCap = 500000;
            }
            else if (chucvu.ToString() == "pp")
            {
                phuCap = 300000;
            }
           
            tienLinh = nv.BacLuong * 650000 * nctl + phuCap;
            ViewBag.maNV = nv.MaNV;
            ViewBag.ngayCong = nv.NgayCong;
            ViewBag.tienLinh = tienLinh;
            return View();
            
        }
    }
}