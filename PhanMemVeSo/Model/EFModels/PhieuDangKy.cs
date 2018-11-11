namespace Model.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDangKy")]
    public partial class PhieuDangKy
    {
        public int PhieuDangKyId { get; set; }

        public int LoaiVeSoId { get; set; }

        public int DaiLyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        public decimal SLDangKy { get; set; }

        public virtual DaiLy DaiLy { get; set; }

        public virtual LoaiVeSo LoaiVeSo { get; set; }
    }
}
