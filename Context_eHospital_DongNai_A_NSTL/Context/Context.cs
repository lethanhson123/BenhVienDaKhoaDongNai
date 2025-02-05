namespace Data_eHospital_DongNai_A_NSTL.Context
{
	public partial class Context : DbContext
	{
		public Context()
		{
		}
		public Context(DbContextOptions<Context>
    options)
    : base(options)
    {
    }

    public virtual DbSet<ChamCong> ChamCong { get; set; }
public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
public virtual DbSet<DM_NgachBac_Excel> DM_NgachBac_Excel { get; set; }
public virtual DbSet<DM_NhanVienExcel> DM_NhanVienExcel { get; set; }
public virtual DbSet<dtproperties> dtproperties { get; set; }
public virtual DbSet<NS_BANGCAP> NS_BANGCAP { get; set; }
public virtual DbSet<NS_BANGCAP_BK20171228> NS_BANGCAP_BK20171228 { get; set; }
public virtual DbSet<NS_BANGCAP_UV> NS_BANGCAP_UV { get; set; }
public virtual DbSet<NS_CHAMCONG> NS_CHAMCONG { get; set; }
public virtual DbSet<NS_CONGTAC> NS_CONGTAC { get; set; }
public virtual DbSet<NS_CONGTAC_UV> NS_CONGTAC_UV { get; set; }
public virtual DbSet<NS_DAOTAO> NS_DAOTAO { get; set; }
public virtual DbSet<NS_DeNghiKhenThuong> NS_DeNghiKhenThuong { get; set; }
public virtual DbSet<NS_DIEUCHUYEN> NS_DIEUCHUYEN { get; set; }
public virtual DbSet<NS_DM_BacLuong> NS_DM_BacLuong { get; set; }
public virtual DbSet<NS_DM_BieuThueTNCN> NS_DM_BieuThueTNCN { get; set; }
public virtual DbSet<NS_DM_CaTruc> NS_DM_CaTruc { get; set; }
public virtual DbSet<NS_DM_CHUCDANH_> NS_DM_CHUCDANH_ { get; set; }
public virtual DbSet<NS_DM_CHUCVU_> NS_DM_CHUCVU_ { get; set; }
public virtual DbSet<NS_DM_CHUYENNGANH> NS_DM_CHUYENNGANH { get; set; }
public virtual DbSet<NS_DM_DANTOC_> NS_DM_DANTOC_ { get; set; }
public virtual DbSet<NS_DM_DAOTAO> NS_DM_DAOTAO { get; set; }
public virtual DbSet<NS_DM_DinhSuat> NS_DM_DinhSuat { get; set; }
public virtual DbSet<NS_DM_HopDong> NS_DM_HopDong { get; set; }
public virtual DbSet<NS_DM_LoaiTruc> NS_DM_LoaiTruc { get; set; }
public virtual DbSet<NS_DM_LoaiTruc_NgoaiGio> NS_DM_LoaiTruc_NgoaiGio { get; set; }
public virtual DbSet<NS_DM_LYDONGHIPHEP> NS_DM_LYDONGHIPHEP { get; set; }
public virtual DbSet<NS_DM_LyDoNghiViec> NS_DM_LyDoNghiViec { get; set; }
public virtual DbSet<NS_DM_LYDOVANGMAT> NS_DM_LYDOVANGMAT { get; set; }
public virtual DbSet<NS_DM_MucHuongDocHai> NS_DM_MucHuongDocHai { get; set; }
public virtual DbSet<NS_DM_NgachLuong> NS_DM_NgachLuong { get; set; }
public virtual DbSet<NS_DM_NGAYLE> NS_DM_NGAYLE { get; set; }
public virtual DbSet<NS_DM_NGHENGHIEP> NS_DM_NGHENGHIEP { get; set; }
public virtual DbSet<NS_DM_NHOM> NS_DM_NHOM { get; set; }
public virtual DbSet<NS_DM_PHONGBAN_> NS_DM_PHONGBAN_ { get; set; }
public virtual DbSet<NS_DM_PhuCap> NS_DM_PhuCap { get; set; }
public virtual DbSet<NS_DM_PHUCAPTRUC> NS_DM_PHUCAPTRUC { get; set; }
public virtual DbSet<NS_DM_QUANHE> NS_DM_QUANHE { get; set; }
public virtual DbSet<NS_DM_QUANHUYEN> NS_DM_QUANHUYEN { get; set; }
public virtual DbSet<NS_DM_QUOCTICH_> NS_DM_QUOCTICH_ { get; set; }
public virtual DbSet<NS_DM_TenDanhHieuThiDua> NS_DM_TenDanhHieuThiDua { get; set; }
public virtual DbSet<NS_DM_ThoiGianDiHoc> NS_DM_ThoiGianDiHoc { get; set; }
public virtual DbSet<NS_DM_TINH> NS_DM_TINH { get; set; }
public virtual DbSet<NS_DM_TinhTrangQuanHe> NS_DM_TinhTrangQuanHe { get; set; }
public virtual DbSet<NS_DM_TONGIAO> NS_DM_TONGIAO { get; set; }
public virtual DbSet<NS_DM_TRINHDO> NS_DM_TRINHDO { get; set; }
public virtual DbSet<NS_DM_TRINHDOCHUYENMON_> NS_DM_TRINHDOCHUYENMON_ { get; set; }
public virtual DbSet<NS_DM_TRINHDONGOAINGU> NS_DM_TRINHDONGOAINGU { get; set; }
public virtual DbSet<NS_DSField> NS_DSField { get; set; }
public virtual DbSet<NS_DSTable> NS_DSTable { get; set; }
public virtual DbSet<NS_GIAHANHOPDONG> NS_GIAHANHOPDONG { get; set; }
public virtual DbSet<NS_HOPDONGLAODONG> NS_HOPDONGLAODONG { get; set; }
public virtual DbSet<NS_KHENTHUONGKYLUAT> NS_KHENTHUONGKYLUAT { get; set; }
public virtual DbSet<NS_KhoaBangChamCong> NS_KhoaBangChamCong { get; set; }
public virtual DbSet<NS_KhoaBangLuong> NS_KhoaBangLuong { get; set; }
public virtual DbSet<NS_KINHNGHIEMCHUYENMON> NS_KINHNGHIEMCHUYENMON { get; set; }
public virtual DbSet<NS_L_CHAMCONGVANG> NS_L_CHAMCONGVANG { get; set; }
public virtual DbSet<NS_L_CHITIEU_NV> NS_L_CHITIEU_NV { get; set; }
public virtual DbSet<NS_L_DMCHITIEU> NS_L_DMCHITIEU { get; set; }
public virtual DbSet<NS_LICHTRUC> NS_LICHTRUC { get; set; }
public virtual DbSet<NS_NGACHBACLUONG> NS_NGACHBACLUONG { get; set; }
public virtual DbSet<NS_NGHIPHEP> NS_NGHIPHEP { get; set; }
public virtual DbSet<NS_NGOAINGU> NS_NGOAINGU { get; set; }
public virtual DbSet<NS_NGOAINGU_UV> NS_NGOAINGU_UV { get; set; }
public virtual DbSet<NS_NHANVIEN> NS_NHANVIEN { get; set; }
public virtual DbSet<NS_NhanVien_Lich_CaTruc> NS_NhanVien_Lich_CaTruc { get; set; }
public virtual DbSet<NS_NhanVien_NhanVien> NS_NhanVien_NhanVien { get; set; }
public virtual DbSet<NS_NhanVien_PhongBan> NS_NhanVien_PhongBan { get; set; }
public virtual DbSet<NS_PHEPNAM> NS_PHEPNAM { get; set; }
public virtual DbSet<NS_PhongBan_DinhSuat> NS_PhongBan_DinhSuat { get; set; }
public virtual DbSet<NS_QUANHEGIADINH> NS_QUANHEGIADINH { get; set; }
public virtual DbSet<NS_RP_DSField> NS_RP_DSField { get; set; }
public virtual DbSet<NS_RP_DSOperator> NS_RP_DSOperator { get; set; }
public virtual DbSet<NS_RP_DSQuery> NS_RP_DSQuery { get; set; }
public virtual DbSet<NS_RP_DSTable> NS_RP_DSTable { get; set; }
public virtual DbSet<NS_RP_FILTER> NS_RP_FILTER { get; set; }
public virtual DbSet<NS_RP_FORMULARS> NS_RP_FORMULARS { get; set; }
public virtual DbSet<NS_RP_LSTFILTER> NS_RP_LSTFILTER { get; set; }
public virtual DbSet<NS_RP_LSTREPORT> NS_RP_LSTREPORT { get; set; }
public virtual DbSet<NS_RP_LSTSUBREPORT> NS_RP_LSTSUBREPORT { get; set; }
public virtual DbSet<NS_SYS_HANGSO> NS_SYS_HANGSO { get; set; }
public virtual DbSet<NS_SYS_tblFunctionList> NS_SYS_tblFunctionList { get; set; }
public virtual DbSet<NS_ThiDua> NS_ThiDua { get; set; }
public virtual DbSet<NS_THONGTINUNGVIEN> NS_THONGTINUNGVIEN { get; set; }
public virtual DbSet<NS_TUYENDUNG> NS_TUYENDUNG { get; set; }
public virtual DbSet<NS_XepLichTruc> NS_XepLichTruc { get; set; }
public virtual DbSet<NS_XepLichTruc_NgoaiGio> NS_XepLichTruc_NgoaiGio { get; set; }
public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
public virtual DbSet<T_FK_Xref> T_FK_Xref { get; set; }
public virtual DbSet<ThongTinChamCong> ThongTinChamCong { get; set; }
public virtual DbSet<z_Import> z_Import { get; set; }
public virtual DbSet<zTemp_NV_excel> zTemp_NV_excel { get; set; }
public virtual DbSet<ZZZ_NhanVienSOBHXH> ZZZ_NhanVienSOBHXH { get; set; }
public virtual DbSet<zzzNhanVien_2023_05_23> zzzNhanVien_2023_05_23 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    if (!optionsBuilder.IsConfigured)
    {
    optionsBuilder.UseSqlServer(GlobalHelper.SQLServerConectionString_eHospital_DongNai_A_NSTL);
    }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
    }

