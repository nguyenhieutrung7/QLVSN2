namespace Model.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Giai")]
    public partial class Giai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giai()
        {
            KetQuaXoSoes = new HashSet<KetQuaXoSo>();
        }

        public int GiaiId { get; set; }

        [Required]
        [StringLength(120)]
        public string TenGiai { get; set; }

        public decimal TienThuong { get; set; }

        public int SLSoTrung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetQuaXoSo> KetQuaXoSoes { get; set; }
    }
}
