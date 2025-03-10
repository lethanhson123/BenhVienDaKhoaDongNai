
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
        public virtual DbSet<DanhMucThongKe> DanhMucThongKe { get; set; }
        public virtual DbSet<ThongKe> ThongKe { get; set; }
        public virtual DbSet<ThongKeChiTiet> ThongKeChiTiet { get; set; }

        public virtual DbSet<DanhMucChucDanh> DanhMucChucDanh { get; set; }
        public virtual DbSet<DanhMucPhongBan> DanhMucPhongBan { get; set; }
        public virtual DbSet<DanhMucBacLuong> DanhMucBacLuong { get; set; }
        public virtual DbSet<DanhMucBangCap> DanhMucBangCap { get; set; }
        public virtual DbSet<DanhMucChucVu> DanhMucChucVu { get; set; }
        public virtual DbSet<DanhMucChuyenNganh> DanhMucChuyenNganh { get; set; }
        public virtual DbSet<DanhMucPhuCap> DanhMucPhuCap { get; set; }
        public virtual DbSet<DanhMucToChucDaoTao> DanhMucToChucDaoTao { get; set; }
        public virtual DbSet<DanhMucChamCong> DanhMucChamCong { get; set; }
        public virtual DbSet<DanhMucGiamTru> DanhMucGiamTru { get; set; }
        public virtual DbSet<DanhMucHopDong> DanhMucHopDong { get; set; }
        public virtual DbSet<DanhMucLuongCoBan> DanhMucLuongCoBan { get; set; }
        public virtual DbSet<DanhMucNganHang> DanhMucNganHang { get; set; }
        public virtual DbSet<DanhMucThue> DanhMucThue { get; set; }
        public virtual DbSet<HRBangLuong> HRBangLuong { get; set; }

        public virtual DbSet<HRBangLuongChiTiet> HRBangLuongChiTiet { get; set; }
        public virtual DbSet<HRChamCong> HRChamCong { get; set; }
        public virtual DbSet<HRChamCongChiTiet> HRChamCongChiTiet { get; set; }
        public virtual DbSet<HRLichCongTac> HRLichCongTac { get; set; }
        public virtual DbSet<HRLichCongTacChiTiet> HRLichCongTacChiTiet { get; set; }
        public virtual DbSet<HRNhanVien> HRNhanVien { get; set; }
        public virtual DbSet<HRNhanVienBangCap> HRNhanVienBangCap { get; set; }
        public virtual DbSet<HRNhanVienHopDong> HRNhanVienHopDong { get; set; }
        public virtual DbSet<HRNhanVienNganHang> HRNhanVienNganHang { get; set; }
        public virtual DbSet<HRNhanVienPhuCap> HRNhanVienPhuCap { get; set; }
        public virtual DbSet<HRNhanVienTapTinDinhKem> HRNhanVienTapTinDinhKem { get; set; }
        public virtual DbSet<HRNhanVienThanhVien> HRNhanVienThanhVien { get; set; }

        public virtual DbSet<DanhMucBenhVien> DanhMucBenhVien { get; set; }        
        public virtual DbSet<DanhMucChucNang> DanhMucChucNang { get; set; }        
        public virtual DbSet<DanhMucThanhVien> DanhMucThanhVien { get; set; }
        public virtual DbSet<DanhMucTinhTrang> DanhMucTinhTrang { get; set; }
        public virtual DbSet<DanhMucBieuMau> DanhMucBieuMau { get; set; }
        public virtual DbSet<DanhMucHinhThucThanhToan> DanhMucHinhThucThanhToan { get; set; }
        public virtual DbSet<DanhMucUngDung> DanhMucUngDung { get; set; }
        public virtual DbSet<DanhMucMauSac> DanhMucMauSac { get; set; }
        public virtual DbSet<DanhMucQuanHuyen> DanhMucQuanHuyen { get; set; }
        public virtual DbSet<DanhMucQuocGia> DanhMucQuocGia { get; set; }
        public virtual DbSet<DanhMucTinhThanh> DanhMucTinhThanh { get; set; }
        public virtual DbSet<DanhMucTinhThanhToaDo> DanhMucTinhThanhToaDo { get; set; }
        public virtual DbSet<DanhMucXaPhuong> DanhMucXaPhuong { get; set; }

        public virtual DbSet<DanhMucDichVu> DanhMucDichVu { get; set; }
        public virtual DbSet<DanhMucKhuVuc> DanhMucKhuVuc { get; set; }
        public virtual DbSet<DanhMucPhongKham> DanhMucPhongKham { get; set; }
        public virtual DbSet<DanhMucQuayDichVu> DanhMucQuayDichVu { get; set; }
        public virtual DbSet<DanhMucKhoaChuyenMon> DanhMucKhoaChuyenMon { get; set; }

        public virtual DbSet<ThanhVien> ThanhVien { get; set; }
        public virtual DbSet<ThanhVienChucNang> ThanhVienChucNang { get; set; }
        public virtual DbSet<ThanhVienLichSuTruyCap> ThanhVienLichSuTruyCap { get; set; }
        public virtual DbSet<ThanhVienToken> ThanhVienToken { get; set; }
        public virtual DbSet<ThanhVienUngDung> ThanhVienUngDung { get; set; }
        public virtual DbSet<ThanhVienDichVu> ThanhVienDichVu { get; set; }
        public virtual DbSet<ThanhVienPhongKham> ThanhVienPhongKham { get; set; }
        public virtual DbSet<ThanhVienQuayDichVu> ThanhVienQuayDichVu { get; set; }

        public virtual DbSet<CongViec> CongViec { get; set; }
        public virtual DbSet<CongViecTapTinDinhKem> CongViecTapTinDinhKem { get; set; }

        public virtual DbSet<ToChuc> ToChuc { get; set; }
        public virtual DbSet<ToChucTaiKhoan> ToChucTaiKhoan { get; set; }

        public virtual DbSet<KhachHang> KhachHang { get; set; }

        //public virtual DbSet<DuAn> DuAn { get; set; }
        //public virtual DbSet<DuAnTapTinDinhKem> DuAnTapTinDinhKem { get; set; }
        //public virtual DbSet<DuAnThuChi> DuAnThuChi { get; set; }
        //public virtual DbSet<DuAnQuyetDinh> DuAnQuyetDinh { get; set; }
        //public virtual DbSet<DuAnQuyetToan> DuAnQuyetToan { get; set; }
        //public virtual DbSet<DuAnQuyetToanLuyKe> DuAnQuyetToanLuyKe { get; set; }
        //public virtual DbSet<DuAnQuyetToanPhanKy> DuAnQuyetToanPhanKy { get; set; }

        public virtual DbSet<GoiSo> GoiSo { get; set; }
        public virtual DbSet<GoiSoChiTiet> GoiSoChiTiet { get; set; }
        public virtual DbSet<GoiSoChiTietICD> GoiSoChiTietICD { get; set; }
        public virtual DbSet<GoiSoChiTietPhongKham> GoiSoChiTietPhongKham { get; set; }
        public virtual DbSet<GoiSoThamSo> GoiSoThamSo { get; set; }

        public virtual DbSet<ManHinhTapTinDinhKem> ManHinhTapTinDinhKem { get; set; }
        public virtual DbSet<ManHinhThongBao> ManHinhThongBao { get; set; }

        public virtual DbSet<TaiLieu> TaiLieu { get; set; }

        public virtual DbSet<ZaloToken> ZaloToken { get; set; }
        public virtual DbSet<ZaloZNS> ZaloZNS { get; set; }

        public virtual DbSet<KhamSucKhoe> KhamSucKhoe { get; set; }
        public virtual DbSet<KhamSucKhoeKetQua> KhamSucKhoeKetQua { get; set; }
        public virtual DbSet<TrucBanNhatKy> TrucBanNhatKy { get; set; }

        public virtual DbSet<QuanLyCongViec> QuanLyCongViec { get; set; }

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
