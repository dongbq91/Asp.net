using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai5.Models;

namespace Bai5.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Save(FormCollection f)
        {
            var fhinh = Request.Files["myfileImage"];

            var pathhinh = Server.MapPath("~/Images" + fhinh.FileName);
            fhinh.SaveAs(pathhinh);

            string path = Server.MapPath("~/myfileImage.txt");
            string[] info = { f["txtID"], f["txtName"], f["txtDate"], f["txtSalary"], fhinh.FileName };
            System.IO.File.WriteAllLines(path, info);
            return View("Index");

        }
        public ActionResult open()
        {
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            Staff s = new Staff();
            s.StaffID = int.Parse(info[0]);
            s.StaffName = info[1];
            s.BirthofDate = DateTime.Parse(info[2]);
            s.Salary = decimal.Parse(info[3]);
            s.StaffImage = info[4];

            ViewBag.id = s.StaffID;
            ViewBag.name = s.StaffName;
            ViewBag.birthday = s.BirthofDate.ToString("yyyy-MM-dd");
            ViewBag.salary = s.Salary;
            ViewBag.image = "../../Images/" + s.StaffImage;

            return View("Index");
        }
    }
}