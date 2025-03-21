﻿
using System.Reflection.Metadata;

namespace Data_eHospital_DongNai_A_Dictionary.Context
{
	public partial class Context : DbContext
	{
		public Context()
		{
		}
		public Context(DbContextOptions<Context> options)
        : base(options)
        {
		}
        public virtual DbSet<DM_BenhNhan> DM_BenhNhan { get; set; }
        public virtual DbSet<DM_BenhNhan_BHYT> DM_BenhNhan_BHYT { get; set; }
        public virtual DbSet<DM_BenhVien> DM_BenhVien { get; set; }
        public virtual DbSet<DM_DonViHanhChinh> DM_DonViHanhChinh { get; set; }
        public virtual DbSet<Lst_Dictionary> Lst_Dictionary { get; set; }
        public virtual DbSet<Lst_Dictionary_Type> Lst_Dictionary_Type { get; set; }
        public virtual DbSet<DM_DichVu> DM_DichVu { get; set; }
        public virtual DbSet<DM_DonViTinh> DM_DonViTinh { get; set; }
        public virtual DbSet<DM_ICD> DM_ICD { get; set; }
        public virtual DbSet<DM_ICD_Chuong> DM_ICD_Chuong { get; set; }
        public virtual DbSet<DM_ICD_Common> DM_ICD_Common { get; set; }
        public virtual DbSet<DM_ICD_Nhom> DM_ICD_Nhom { get; set; }
        public virtual DbSet<DM_KhoDuoc> DM_KhoDuoc { get; set; }
        public virtual DbSet<DM_NhomDichVu> DM_NhomDichVu { get; set; }
        public virtual DbSet<DM_PhongBan> DM_PhongBan { get; set; }
        public virtual DbSet<DM_LoaiDichVu> DM_LoaiDichVu { get; set; }
        public virtual DbSet<DM_BangGia> DM_BangGia { get; set; }
        public virtual DbSet<DM_BangGia_CPH> DM_BangGia_CPH { get; set; }
        public virtual DbSet<DM_DichVu_DonGia> DM_DichVu_DonGia { get; set; }
        public virtual DbSet<DM_DichVu_DonGia_CPH> DM_DichVu_DonGia_CPH { get; set; }
        public virtual DbSet<DM_LoaiGia> DM_LoaiGia { get; set; }
        public virtual DbSet<DM_LoaiBenhAn> DM_LoaiBenhAn { get; set; }
        public virtual DbSet<DM_DoiTuong> DM_DoiTuong { get; set; }
        public virtual DbSet<NhanVien_User_Mapping> NhanVien_User_Mapping { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A_Dictionary);
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            var decimalProps = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));
            foreach (var property in decimalProps)
            {
                property.SetPrecision(18);
                property.SetScale(2);
            }
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<DM_PhongBan>().ToTable(tb => tb.UseSqlOutputClause(false));
        }
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
