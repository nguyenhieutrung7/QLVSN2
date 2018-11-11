namespace Model.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQuaXoSo")]
    public partial class KetQuaXoSo
    {
        public int KetQuaXoSoId { get; set; }

        public int LoaiVeSoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXoSo { get; set; }

        public int GiaiId { get; set; }

        public int SoTrung { get; set; }

        public virtual Giai Giai { get; set; }

        public virtual LoaiVeSo LoaiVeSo { get; set; }
    }
}
