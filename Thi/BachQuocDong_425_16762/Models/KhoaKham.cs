namespace BachQuocDong_425_16762.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoaKham")]
    public partial class KhoaKham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoaKham()
        {
            BenhNhans = new HashSet<BenhNhan>();
        }

        [Key]
        [StringLength(10)]
        public string Makhoa { get; set; }

        [StringLength(50)]
        public string Tenkhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhNhan> BenhNhans { get; set; }
    }
}
