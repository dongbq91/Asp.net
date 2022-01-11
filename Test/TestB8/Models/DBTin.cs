using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TestB8.Models
{
    public partial class DBTin : DbContext
    {
        public DBTin()
            : base("name=DBTin")
        {
        }

        public virtual DbSet<Theloaitin> Theloaitins { get; set; }
        public virtual DbSet<Tintuc> Tintucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
