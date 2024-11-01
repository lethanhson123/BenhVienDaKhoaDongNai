﻿
namespace Data.Context
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
        public virtual DbSet<Data.Model.DanhMucBenhVien> DanhMucBenhVien { get; set; }
        public virtual DbSet<Data.Model.DanhMucChucDanh> DanhMucChucDanh { get; set; }
        public virtual DbSet<Data.Model.DanhMucChucNang> DanhMucChucNang { get; set; }
        public virtual DbSet<Data.Model.DanhMucPhongBan> DanhMucPhongBan { get; set; }
        public virtual DbSet<Data.Model.DanhMucThanhVien> DanhMucThanhVien { get; set; }
        public virtual DbSet<Data.Model.DanhMucTinhTrang> DanhMucTinhTrang { get; set; }
        public virtual DbSet<Data.Model.DanhMucBieuMau> DanhMucBieuMau { get; set; }
        public virtual DbSet<Data.Model.DanhMucHinhThucThanhToan> DanhMucHinhThucThanhToan { get; set; }

        public virtual DbSet<Data.Model.ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<Data.Model.ThanhVienChucNang> ThanhVienChucNang { get; set; }
        public virtual DbSet<Data.Model.ThanhVienLichSuTruyCap> ThanhVienLichSuTruyCap { get; set; }
        public virtual DbSet<Data.Model.ThanhVienToken> ThanhVienToken { get; set; }

        public virtual DbSet<Data.Model.CongViec> CongViec { get; set; }
        public virtual DbSet<Data.Model.CongViecTapTinDinhKem> CongViecTapTinDinhKem { get; set; }

        public virtual DbSet<Data.Model.ToChuc> ToChuc { get; set; }
        public virtual DbSet<Data.Model.ToChucTaiKhoan> ToChucTaiKhoan { get; set; }

        public virtual DbSet<Data.Model.DuAn> DuAn { get; set; }
        public virtual DbSet<Data.Model.DuAnTapTinDinhKem> DuAnTapTinDinhKem { get; set; }
        public virtual DbSet<Data.Model.DuAnThuChi> DuAnThuChi { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetDinh> DuAnQuyetDinh { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetToan> DuAnQuyetToan { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetToanLuyKe> DuAnQuyetToanLuyKe { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetToanPhanKy> DuAnQuyetToanPhanKy { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(GlobalHelper.SQLServerConectionString);
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			OnModelCreatingPartial(modelBuilder);
		}
		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
