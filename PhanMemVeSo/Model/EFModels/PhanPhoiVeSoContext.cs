namespace Model.EFModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhanPhoiVeSoContext : DbContext
    {
        public PhanPhoiVeSoContext()
            : base("name=PhanPhoiVeSoContext")
        {
        }

        public virtual DbSet<DaiLy> DaiLies { get; set; }
        public virtual DbSet<Giai> Giais { get; set; }
        public virtual DbSet<KetQuaXoSo> KetQuaXoSoes { get; set; }
        public virtual DbSet<LoaiVeSo> LoaiVeSoes { get; set; }
        public virtual DbSet<PhieuDangKy> PhieuDangKies { get; set; }
        public virtual DbSet<PhieuPhatHanh> PhieuPhatHanhs { get; set; }
        public virtual DbSet<PhieuThu> PhieuThus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DaiLy>()
                .HasMany(e => e.PhieuDangKies)
                .WithRequired(e => e.DaiLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DaiLy>()
                .HasMany(e => e.PhieuPhatHanhs)
                .WithRequired(e => e.DaiLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DaiLy>()
                .HasMany(e => e.PhieuThus)
                .WithRequired(e => e.DaiLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Giai>()
                .Property(e => e.TienThuong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Giai>()
                .HasMany(e => e.KetQuaXoSoes)
                .WithRequired(e => e.Giai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiVeSo>()
                .HasMany(e => e.KetQuaXoSoes)
                .WithRequired(e => e.LoaiVeSo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiVeSo>()
                .HasMany(e => e.PhieuDangKies)
                .WithRequired(e => e.LoaiVeSo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiVeSo>()
                .HasMany(e => e.PhieuPhatHanhs)
                .WithRequired(e => e.LoaiVeSo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuDangKy>()
                .Property(e => e.SLDangKy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhieuPhatHanh>()
                .Property(e => e.SLPhat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhieuPhatHanh>()
                .Property(e => e.SLBanDuoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhieuThu>()
                .Property(e => e.TienThu)
                .HasPrecision(18, 0);
        }
    }
}
