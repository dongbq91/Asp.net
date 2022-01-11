using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4.Models;

namespace Bai4.Controllers
{
    public class NhapDiemSVController : Controller
    {
        // GET: NhapDiemSV
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(Sinhvien sv)
        {
            sv.Id = "SV01";
            sv.Name = "Bạch Quốc Đông";
            sv.Diem = 10;
            return View(sv);
        }
    }
}