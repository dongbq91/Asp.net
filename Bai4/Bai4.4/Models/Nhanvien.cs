using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai4._4.Models
{
    public class Nhanvien
    {

        private string maNV;
        private int bacLuong;
        private int ngayCong;
        private string chucVu;
        private string gioiTinh;
        private string ngoaiNgu;

        public string MaNV { get => maNV; set => maNV = value; }
        public int BacLuong { get => bacLuong; set => bacLuong = value; }
        public int NgayCong { get => ngayCong; set => ngayCong = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgoaiNgu { get => ngoaiNgu; set => ngoaiNgu = value; }
    }
}