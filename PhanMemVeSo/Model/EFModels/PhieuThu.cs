namespace Model.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThu")]
    public partial class PhieuThu
    {
        public int PhieuThuId { get; set; }

        public int DaiLyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThu { get; set; }

        public decimal TienThu { get; set; }

        public virtual DaiLy DaiLy { get; set; }
    }
}
