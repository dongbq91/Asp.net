namespace BachQuocDong_2018604425_De2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoSo")]
    public partial class HoSo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Mã không được để trống!")]
        [Key]
        [StringLength(10)]
        public string Mahs { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Họ tên không được để trống!")]
        public string Hoten { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Đơn vị không được để trống!")]
        public string Donvi { get; set; }

        public int? Bacluong { get; set; }
    }
}
