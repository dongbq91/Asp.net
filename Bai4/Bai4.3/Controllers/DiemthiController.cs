using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4._3.Models;

namespace Bai4._3.Controllers
{
    public class DiemthiController : Controller
    {
        // GET: Diemthi
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tinhd( Sinhvien sv, FormCollection data)
        {
            string Ten = data["ten"];
            string Giadinh = data["giadinh"];

            var checkbox = Request.Form.GetValues("giadinh")[0];
            int diem;
            int diemcheck;
            int diemkv;
            int diemthi = sv.Toan + sv.Ly + sv.Hoa;
            if (checkbox == "true")
            {
                diemcheck =  1 ;
            }
            else
            {
                diemcheck = 0 ;
            }
            string khuvuc = data["khuvuc"];
            if (khuvuc.ToString() == "a")
            {
                diemkv =1;
            }
            else if (khuvuc.ToString() == "b")
            {
                diemkv = 2;
            }
            else if (khuvuc.ToString() == "c")
            {
                diemkv = 3;
            }
            else
            {
                diemkv = 0;
            }
            diem = diemthi + diemkv + diemcheck;
            string Ketqua = data["ketqua"];

            if (diem >= 20)
            {
                Ketqua = "Đỗ đại học";
            }
            else if (diem >= 15)
            {
                Ketqua = "Đỗ cao đẳng";
            }
            else if (diem >= 10)
            {
                Ketqua = "Đỗ trung cấp";
            }
            else if (diem < 10)
            {
                Ketqua = "Trượt đại học";
            }

        

            ViewBag.ten = Ten;
            ViewBag.diem = diem;
            ViewBag.ketqua = Ketqua;
            return View();
        }
    }
}