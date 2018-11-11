namespace Model.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuPhatHanh")]
    public partial class PhieuPhatHanh
    {
        public int PhieuPhatHanhId { get; set; }

        public int DaiLyId { get; set; }

        public int LoaiVeSoId { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayPhat { get; set; }

        public decimal SLPhat { get; set; }

        public decimal? SLBanDuoc { get; set; }

        public virtual DaiLy DaiLy { get; set; }

        public virtual LoaiVeSo LoaiVeSo { get; set; }
    }
}
