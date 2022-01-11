using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai12_Shop.Models
{
    public class SanphamMua
    {
        public string masp { get; set; }
        public int soluong { get; set; }

        public override bool Equals(object obj)
        {
            SanphamMua spm = (SanphamMua)obj;
            return (this.masp == spm.masp);
        }

    }
}