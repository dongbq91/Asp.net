using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4._2.Models;

namespace Bai4._2.Controllers
{
    public class TiendienController : Controller
    {
        // GET: Tiendien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tinhtiendien(TiendienModel td, FormCollection data)
        {
            string Ten = data["ten"];
            var checkbox = Request.Form.GetValues("ho")[0];
            string Giadinh = data["giadinh"];
            int sodien = td.Moi - td.Cu;
            int tiendien =0;
            int dienbac=0;
            if (sodien < 0)
            {

            }
            else if(0<sodien && sodien <= 100)
            {
                dienbac = sodien * 200;
            }
            else if (0 < sodien && sodien <= 100)
            {
                dienbac = 100 * 2000 + (sodien - 100) * 2500;
            }
            else if (100 < sodien && sodien <= 150)
            {
                dienbac = sodien * 200;
            }
            else if (150 < sodien && sodien <= 200)
            {
                dienbac = 100 * 2000 + 50 * 2500 + (sodien - 150) * 3000;
            }
            else
            {
                dienbac = 100 * 2000 + 50 * 2500 + 50 * 3000 + (sodien - 200) * 4000;
            }
            if(checkbox == "true")
            {
                tiendien = dienbac - (10 * dienbac) / 100;
            }
            string khuvuc = data["loaidien"];
            if (khuvuc.ToString() == "kd")
            {
                tiendien = dienbac + (20 * dienbac) / 100;
            }
            else if (khuvuc.ToString() == "sx")
            {
                tiendien = dienbac + (30 * dienbac) / 100;
            }

            ViewBag.ten = Ten;
            ViewBag.sodien = sodien;
            ViewBag.tiendien = tiendien;
            return View();
        }
    }
}