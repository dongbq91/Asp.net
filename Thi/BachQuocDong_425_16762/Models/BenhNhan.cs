namespace BachQuocDong_425_16762.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BenhNhan")]
    public partial class BenhNhan
    {
        [Key]
        [StringLength(10)]
        public string Mabn { get; set; }

        [StringLength(50)]
        public string Hoten { get; set; }

        [StringLength(100)]
        public string Diachi { get; set; }

        public int? SongayNV { get; set; }

        [StringLength(10)]
        public string Makhoa { get; set; }

        public virtual KhoaKham KhoaKham { get; set; }
    }
}
