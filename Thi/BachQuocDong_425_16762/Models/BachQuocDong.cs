using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BachQuocDong_425_16762.Models
{
    public partial class BachQuocDong : DbContext
    {
        public BachQuocDong()
            : base("name=BachQuocDong")
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<KhoaKham> KhoaKhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.Mabn)
                .IsFixedLength();

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.Makhoa)
                .IsFixedLength();

            modelBuilder.Entity<KhoaKham>()
                .Property(e => e.Makhoa)
                .IsFixedLength();
        }
    }
}
