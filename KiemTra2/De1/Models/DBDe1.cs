using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace De1.Models
{
    public partial class DBDe1 : DbContext
    {
        public DBDe1()
            : base("name=DBDe1")
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Manv)
                .IsFixedLength();
        }
    }
}
