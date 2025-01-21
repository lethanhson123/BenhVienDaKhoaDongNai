
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
        public virtual DbSet<Data.Model.DanhMucUngDung> DanhMucUngDung { get; set; }
        public virtual DbSet<Data.Model.DanhMucMauSac> DanhMucMauSac { get; set; }
        public virtual DbSet<Data.Model.DanhMucQuanHuyen> DanhMucQuanHuyen { get; set; }
        public virtual DbSet<Data.Model.DanhMucQuocGia> DanhMucQuocGia { get; set; }
        public virtual DbSet<Data.Model.DanhMucTinhThanh> DanhMucTinhThanh { get; set; }
        public virtual DbSet<Data.Model.DanhMucTinhThanhToaDo> DanhMucTinhThanhToaDo { get; set; }
        public virtual DbSet<Data.Model.DanhMucXaPhuong> DanhMucXaPhuong { get; set; }

        public virtual DbSet<Data.Model.DanhMucDichVu> DanhMucDichVu { get; set; }
        public virtual DbSet<Data.Model.DanhMucKhuVuc> DanhMucKhuVuc { get; set; }
        public virtual DbSet<Data.Model.DanhMucPhongKham> DanhMucPhongKham { get; set; }
        public virtual DbSet<Data.Model.DanhMucQuayDichVu> DanhMucQuayDichVu { get; set; }
        public virtual DbSet<Data.Model.DanhMucKhoaChuyenMon> DanhMucKhoaChuyenMon { get; set; }

        public virtual DbSet<Data.Model.ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<Data.Model.ThanhVienChucNang> ThanhVienChucNang { get; set; }
        public virtual DbSet<Data.Model.ThanhVienLichSuTruyCap> ThanhVienLichSuTruyCap { get; set; }
        public virtual DbSet<Data.Model.ThanhVienToken> ThanhVienToken { get; set; }
        public virtual DbSet<Data.Model.ThanhVienUngDung> ThanhVienUngDung { get; set; }
        public virtual DbSet<Data.Model.ThanhVienDichVu> ThanhVienDichVu { get; set; }
        public virtual DbSet<Data.Model.ThanhVienPhongKham> ThanhVienPhongKham { get; set; }
        public virtual DbSet<Data.Model.ThanhVienQuayDichVu> ThanhVienQuayDichVu { get; set; }

        public virtual DbSet<Data.Model.CongViec> CongViec { get; set; }
        public virtual DbSet<Data.Model.CongViecTapTinDinhKem> CongViecTapTinDinhKem { get; set; }

        public virtual DbSet<Data.Model.ToChuc> ToChuc { get; set; }
        public virtual DbSet<Data.Model.ToChucTaiKhoan> ToChucTaiKhoan { get; set; }

        public virtual DbSet<Data.Model.KhachHang> KhachHang { get; set; }

        public virtual DbSet<Data.Model.DuAn> DuAn { get; set; }
        public virtual DbSet<Data.Model.DuAnTapTinDinhKem> DuAnTapTinDinhKem { get; set; }
        public virtual DbSet<Data.Model.DuAnThuChi> DuAnThuChi { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetDinh> DuAnQuyetDinh { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetToan> DuAnQuyetToan { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetToanLuyKe> DuAnQuyetToanLuyKe { get; set; }
        public virtual DbSet<Data.Model.DuAnQuyetToanPhanKy> DuAnQuyetToanPhanKy { get; set; }

        public virtual DbSet<Data.Model.GoiSo> GoiSo { get; set; }
        public virtual DbSet<Data.Model.GoiSoChiTiet> GoiSoChiTiet { get; set; }
        public virtual DbSet<Data.Model.GoiSoChiTietICD> GoiSoChiTietICD { get; set; }
        public virtual DbSet<Data.Model.GoiSoChiTietPhongKham> GoiSoChiTietPhongKham { get; set; }
        public virtual DbSet<Data.Model.GoiSoThamSo> GoiSoThamSo { get; set; }

        public virtual DbSet<Data.Model.ManHinhTapTinDinhKem> ManHinhTapTinDinhKem { get; set; }
        public virtual DbSet<Data.Model.ManHinhThongBao> ManHinhThongBao { get; set; }

        public virtual DbSet<Data.Model.TaiLieu> TaiLieu { get; set; }

        public virtual DbSet<Data.Model.ZaloToken> ZaloToken { get; set; }
        public virtual DbSet<Data.Model.ZaloZNS> ZaloZNS { get; set; }

        public virtual DbSet<Data.Model.KhamSucKhoe> KhamSucKhoe { get; set; }
        public virtual DbSet<Data.Model.KhamSucKhoeKetQua> KhamSucKhoeKetQua { get; set; }
        public virtual DbSet<Data.Model.TrucBanNhatKy> TrucBanNhatKy { get; set; }

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
