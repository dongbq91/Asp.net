namespace Bai8._2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Key]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [DisplayName("Mô tả")]
        [Column(TypeName = "text")]
        public string Description { get; set; }
        
        [Column(TypeName = "numeric")]
        [DisplayName("Giá nhập")]
        public decimal PurchasePrice { get; set; }
        
        [Column(TypeName = "numeric")]
        [DisplayName("Giá bán")]
        public decimal Price { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [StringLength(20)]
        [DisplayName("Năm sản xuất")]
        public string Vintage { get; set; }

        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        [DisplayName("Mã sản phẩm")]
        [StringLength(10)]
        public string CatalogyID { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Ảnh sản phẩm")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        [DisplayName("Vùng")]
        [StringLength(100)]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}
