using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BachQuocDong_2018604425_De2.Models
{
    public partial class BachQuocDong : DbContext
    {
        public BachQuocDong()
            : base("name=BachQuocDong2")
        {
        }

        public virtual DbSet<HoSo> HoSoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoSo>()
                .Property(e => e.Mahs)
                .IsFixedLength();
        }
    }
}
