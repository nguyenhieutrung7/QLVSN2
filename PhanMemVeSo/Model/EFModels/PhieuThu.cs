//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EFModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuThu
    {
        public int PhieuThuId { get; set; }
        public int DaiLyId { get; set; }
        public System.DateTime NgayThu { get; set; }
        public decimal TienThu { get; set; }
    
        public virtual DaiLy DaiLy { get; set; }
    }
}