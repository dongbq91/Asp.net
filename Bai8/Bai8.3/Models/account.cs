namespace Bai8._3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [Required(ErrorMessage = "Mã ID không được để trống!")]
        [DisplayName("Mã tài khoản")]
        public int id { get; set; }

        
        [Required(ErrorMessage = "UserName không được để trống!")]
        [DisplayName("User Name")]
        [StringLength(50)]
        public string username { get; set; }

        [Required(ErrorMessage = "Tên không được để trống!")]
        [DisplayName("Tên")]
        [StringLength(30)]
        public string fullname { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        [DisplayName("Số điện thoại")]
        [StringLength(20)]
        public string phone { get; set; }

        [Required(ErrorMessage = " Mật khẩu không được để trống!")]
        [DisplayName("Mật khẩu")]
        [StringLength(30)]
        public string password { get; set; }
        [DisplayName("Email")]
        [StringLength(50)]
        public string email { get; set; }
    }
}
