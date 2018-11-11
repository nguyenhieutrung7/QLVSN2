namespace Model.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiVeSo")]
    public partial class LoaiVeSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiVeSo()
        {
            KetQuaXoSoes = new HashSet<KetQuaXoSo>();
            PhieuDangKies = new HashSet<PhieuDangKy>();
            PhieuPhatHanhs = new HashSet<PhieuPhatHanh>();
        }

        public int LoaiVeSoId { get; set; }

        [Required]
        [StringLength(120)]
        public string TenTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetQuaXoSo> KetQuaXoSoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDangKy> PhieuDangKies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuPhatHanh> PhieuPhatHanhs { get; set; }
    }
}
