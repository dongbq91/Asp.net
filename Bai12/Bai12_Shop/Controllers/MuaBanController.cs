using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai12_Shop.Models;

namespace Bai12_Shop.Controllers
{
    public class MuaBanController : Controller
    {
        // GET: MuaBan
        public ActionResult Index()
        {
            List<Sanpham> ds = new List<Sanpham>();
            ds.Add(new Sanpham("sp1", "Iphone", "h1.png", 2000));
            ds.Add(new Sanpham("sp2", "Sam Sung", "h2.png", 1500));
            ds.Add(new Sanpham("sp3", "Oppo", "h3.png", 1000));
            ds.Add(new Sanpham("sp4", "Bphone", "h4.png", 900));
            Session["hanghoa"] = ds;

            return View(ds);
        }
        public ActionResult Chonmua (SanphamMua spm)
        {
            List<SanphamMua> dsmua = (List<SanphamMua>)Session["giohang"];
            if(dsmua == null)
            {
                dsmua = new List<SanphamMua>();
            }
            if (dsmua.Contains(spm))
            {
                int vitri = dsmua.IndexOf(spm);
                dsmua[vitri].soluong++;
            }
            else
            {
                spm.soluong = 1;
                dsmua.Add(spm);
            }
            Session["giohang"] = dsmua;
            return View();
        }
        public ActionResult XoaSanPham (string masp)
        {
            List<SanphamMua> dsmua = (List<SanphamMua>)Session["giohang"];
            SanphamMua s = new SanphamMua();
            s.masp = masp;
            int vitri = dsmua.IndexOf(s);
            s = dsmua[vitri];
            dsmua.Remove(s);
            Session["giohang"] = dsmua;
            return View("Chonmua");
        }
        public ActionResult XemGioHang()
        {
            List<SanphamMua> dsmua = (List<SanphamMua>)Session["giohang"];
            return View(dsmua);
        }
        public ActionResult Datmua()
        {
            List<SanphamMua> dsm = (List<SanphamMua>)Session["giohang"];
            Session.Remove("giohang");
            return View(dsm);
        }
    }
}