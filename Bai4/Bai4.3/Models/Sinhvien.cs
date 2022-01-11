using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai4._3.Models
{
    public class Sinhvien
    {
        private string ten;
        private int toan;
        private int ly;
        private int hoa;
        private int diem;
        private string giadinh;
        private string ketqua;
        private string khuvuc;
        

        
        public string Khuvuc { get => khuvuc; set => khuvuc = value; }
        public string Ketqua { get => ketqua; set => ketqua = value; }
        public string Giadinh { get => giadinh; set => giadinh = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Toan { get => toan; set => toan = value; }
        public int Ly { get => ly; set => ly = value; }
        public int Hoa { get => hoa; set => hoa = value; }
        public int Diem { get => diem; set => diem = value; }
    }
}