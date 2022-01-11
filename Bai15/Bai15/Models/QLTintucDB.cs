using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bai15.Models
{
    public partial class QLTintucDB : DbContext
    {
        public QLTintucDB()
            : base("name=QLTintucDB")
        {
        }

        public virtual DbSet<Theloaitin> Theloaitins { get; set; }
        public virtual DbSet<Tintuc> Tintucs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
