using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai4._2.Models
{
    public class TiendienModel
    {
        private string ten;
        private int cu;
        private int moi;
        private int tien;
        private int ketqua;
        private int tiendien;
        private string ho;


        public string Ten { get => ten; set => ten = value; }
        public int Cu { get => cu; set => cu = value; }
        public int Moi { get => moi; set => moi = value; }
        public int Tien { get => tien; set => tien = value; }
        public int Ketqua { get => ketqua; set => ketqua = value; }
        public int Tiendien { get => tiendien; set => tiendien = value; }

        public string Ho { get => ho; set => ho = value; }
    }
}