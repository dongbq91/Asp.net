using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Xuly()
        {
            String Ma = Request["ID"];
            string Ten = Request["Name"];
            double Diem = Convert.ToDouble(Request["Diem"]);
            ViewBag.ma = Ma;
            ViewBag.ten = Ten;
            ViewBag.diem = Diem;
            return View();
        }
        public ActionResult XulyForm(FormCollection data)
        {
            String Ma = data["ID"];
            string Ten = data["Name"];
            double Diem = Convert.ToDouble(data["Diem"]);
            ViewBag.ma = Ma;
            ViewBag.ten = Ten;
            ViewBag.diem = Diem;
            return View();
        }
    }
}