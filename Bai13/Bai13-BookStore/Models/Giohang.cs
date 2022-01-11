using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bai13_BookStore.Models;
namespace Bai13_BookStore.Models
{
    public class Giohang
    {
        ShopSachDB db = new ShopSachDB();
        public int iMasach { get; set; }
        public string sTensach { get; set; }

        public string sAnhbia { get; set; }
        public Double dDonggia { get; set; }
        public int iSoluong { get; set; }
        public Double dThanhTien 
        { 
            get { return iSoluong * dDonggia; }
        }
        public Giohang (int Masach)
        {
            iMasach = Masach;
            SACH sach = db.SACHes.Single(n => n.Masach == iMasach);
            sTensach = sach.Tensach;
            sAnhbia = sach.Anhbia;
            dDonggia = double.Parse(sach.Giaban.ToString());
            iSoluong = 1;
        }
    }
}