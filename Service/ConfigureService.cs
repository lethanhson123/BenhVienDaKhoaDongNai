
namespace Service
{
    public static class ConfigureService
    {
        public static IServiceCollection AddJWT(this IServiceCollection services)
        {         

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = GlobalHelper.Audience,
                    ValidIssuer = GlobalHelper.Issuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(GlobalHelper.Key))
                };
            });
            return services;
        }
        public static IServiceCollection AddContext(this IServiceCollection services)
        {
            services.AddDbContext<Context>(opts =>
            {
            });
            return services;
        }
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddTransient<IDanhMucQRCodeService, DanhMucQRCodeService>();

            services.AddTransient<IDanhMucThongKeService, DanhMucThongKeService>();
            services.AddTransient<IThongKeService, ThongKeService>();
            services.AddTransient<IThongKeChiTietService, ThongKeChiTietService>();

            services.AddTransient<IDanhMucBenhVienService, DanhMucBenhVienService>();
            services.AddTransient<IDanhMucChucDanhService, DanhMucChucDanhService>();
            services.AddTransient<IDanhMucPhongBanService, DanhMucPhongBanService>();
            services.AddTransient<IDanhMucBacLuongService, DanhMucBacLuongService>();
            services.AddTransient<IDanhMucBangCapService, DanhMucBangCapService>();
            services.AddTransient<IDanhMucChucVuService, DanhMucChucVuService>();
            services.AddTransient<IDanhMucChuyenNganhService, DanhMucChuyenNganhService>();
            services.AddTransient<IDanhMucPhuCapService, DanhMucPhuCapService>();
            services.AddTransient<IDanhMucToChucDaoTaoService, DanhMucToChucDaoTaoService>();
            services.AddTransient<IDanhMucChamCongService, DanhMucChamCongService>();
            services.AddTransient<IDanhMucGiamTruService, DanhMucGiamTruService>();
            services.AddTransient<IDanhMucHopDongService, DanhMucHopDongService>();
            services.AddTransient<IDanhMucLuongCoBanService, DanhMucLuongCoBanService>();
            services.AddTransient<IDanhMucNganHangService, DanhMucNganHangService>();
            services.AddTransient<IDanhMucThueService, DanhMucThueService>();
            services.AddTransient<IDanhMucDonViTinhService, DanhMucDonViTinhService>();
            services.AddTransient<IDanhMucMayChamCongService, DanhMucMayChamCongService>();

            services.AddTransient<IHRBangLuongService, HRBangLuongService>();
            services.AddTransient<IHRBangLuongChiTietService, HRBangLuongChiTietService>();
            services.AddTransient<IHRChamCongService, HRChamCongService>();
            services.AddTransient<IHRChamCongChiTietService, HRChamCongChiTietService>();
            services.AddTransient<IHRLichCongTacService, HRLichCongTacService>();
            services.AddTransient<IHRLichCongTacChiTietService, HRLichCongTacChiTietService>();
            services.AddTransient<IHRNhanVienService, HRNhanVienService>();
            services.AddTransient<IHRNhanVienBangCapService, HRNhanVienBangCapService>();
            services.AddTransient<IHRNhanVienHopDongService, HRNhanVienHopDongService>();
            services.AddTransient<IHRNhanVienNganHangService, HRNhanVienNganHangService>();
            services.AddTransient<IHRNhanVienPhuCapService, HRNhanVienPhuCapService>();
            services.AddTransient<IHRNhanVienTapTinDinhKemService, HRNhanVienTapTinDinhKemService>();
            services.AddTransient<IHRNhanVienThanhVienService, HRNhanVienThanhVienService>();


            services.AddTransient<IDanhMucChucNangService, DanhMucChucNangService>();            
            services.AddTransient<IDanhMucThanhVienService, DanhMucThanhVienService>();
            services.AddTransient<IDanhMucTinhTrangService, DanhMucTinhTrangService>();
            services.AddTransient<IDanhMucBieuMauService, DanhMucBieuMauService>();
            services.AddTransient<IDanhMucHinhThucThanhToanService, DanhMucHinhThucThanhToanService>();
            services.AddTransient<IDanhMucUngDungService, DanhMucUngDungService>();
            services.AddTransient<IDanhMucMauSacService, DanhMucMauSacService>();
            services.AddTransient<IDanhMucQuanHuyenService, DanhMucQuanHuyenService>();
            services.AddTransient<IDanhMucQuocGiaService, DanhMucQuocGiaService>();
            services.AddTransient<IDanhMucTinhThanhService, DanhMucTinhThanhService>();
            services.AddTransient<IDanhMucTinhThanhToaDoService, DanhMucTinhThanhToaDoService>();
            services.AddTransient<IDanhMucXaPhuongService, DanhMucXaPhuongService>();

            services.AddTransient<IDanhMucDichVuService, DanhMucDichVuService>();
            services.AddTransient<IDanhMucKhuVucService, DanhMucKhuVucService>();
            services.AddTransient<IDanhMucPhongKhamService, DanhMucPhongKhamService>();
            services.AddTransient<IDanhMucQuayDichVuService, DanhMucQuayDichVuService>();
            services.AddTransient<IDanhMucKhoaChuyenMonService, DanhMucKhoaChuyenMonService>();

            services.AddTransient<IThanhVienChucNangService, ThanhVienChucNangService>();
            services.AddTransient<IThanhVienLichSuTruyCapService, ThanhVienLichSuTruyCapService>();
            services.AddTransient<IThanhVienService, ThanhVienService>();
            services.AddTransient<IThanhVienTokenService, ThanhVienTokenService>();
            services.AddTransient<IThanhVienUngDungService, ThanhVienUngDungService>();
            services.AddTransient<IThanhVienDichVuService, ThanhVienDichVuService>();
            services.AddTransient<IThanhVienPhongKhamService, ThanhVienPhongKhamService>();
            services.AddTransient<IThanhVienQuayDichVuService, ThanhVienQuayDichVuService>();

            services.AddTransient<ICongViecService, CongViecService>();
            services.AddTransient<ICongViecTapTinDinhKemService, CongViecTapTinDinhKemService>();

            services.AddTransient<IToChucService, ToChucService>();
            services.AddTransient<IToChucTaiKhoanService, ToChucTaiKhoanService>();

            services.AddTransient<IKhachHangService, KhachHangService>();

            //services.AddTransient<IDuAnService, DuAnService>();
            //services.AddTransient<IDuAnTapTinDinhKemService, DuAnTapTinDinhKemService>();
            //services.AddTransient<IDuAnThuChiService, DuAnThuChiService>();
            //services.AddTransient<IDuAnQuyetDinhService, DuAnQuyetDinhService>();
            //services.AddTransient<IDuAnQuyetToanService, DuAnQuyetToanService>();
            //services.AddTransient<IDuAnQuyetToanLuyKeService, DuAnQuyetToanLuyKeService>();
            //services.AddTransient<IDuAnQuyetToanPhanKyService, DuAnQuyetToanPhanKyService>();

            services.AddTransient<IGoiSoService, GoiSoService>();
            services.AddTransient<IGoiSoChiTietService, GoiSoChiTietService>();
            services.AddTransient<IGoiSoChiTietICDService, GoiSoChiTietICDService>();
            services.AddTransient<IGoiSoChiTietPhongKhamService, GoiSoChiTietPhongKhamService>();
            services.AddTransient<IGoiSoThamSoService, GoiSoThamSoService>();

            services.AddTransient<IManHinhTapTinDinhKemService, ManHinhTapTinDinhKemService>();
            services.AddTransient<IManHinhThongBaoService, ManHinhThongBaoService>();

            services.AddTransient<ITaiLieuService, TaiLieuService>();

            services.AddTransient<IZaloTokenService, ZaloTokenService>();
            services.AddTransient<IZaloZNSService, ZaloZNSService>();

            services.AddTransient<IKhamSucKhoeService, KhamSucKhoeService>();
            services.AddTransient<IKhamSucKhoeKetQuaService, KhamSucKhoeKetQuaService>();

            services.AddTransient<ITrucBanNhatKyService, TrucBanNhatKyService>();
            services.AddTransient<IQuanLyCongViecService, QuanLyCongViecService>();

            services.AddTransient<IReportService, ReportService>();

            services.AddSingleton(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IDanhMucQRCodeRepository, DanhMucQRCodeRepository>();

            services.AddTransient<IDanhMucThongKeRepository, DanhMucThongKeRepository>();
            services.AddTransient<IThongKeRepository, ThongKeRepository>();
            services.AddTransient<IThongKeChiTietRepository, ThongKeChiTietRepository>();

            services.AddTransient<IDanhMucBenhVienRepository, DanhMucBenhVienRepository>();
            services.AddTransient<IDanhMucChucDanhRepository, DanhMucChucDanhRepository>();
            services.AddTransient<IDanhMucPhongBanRepository, DanhMucPhongBanRepository>();
            services.AddTransient<IDanhMucBacLuongRepository, DanhMucBacLuongRepository>();
            services.AddTransient<IDanhMucBangCapRepository, DanhMucBangCapRepository>();
            services.AddTransient<IDanhMucChucVuRepository, DanhMucChucVuRepository>();
            services.AddTransient<IDanhMucChuyenNganhRepository, DanhMucChuyenNganhRepository>();
            services.AddTransient<IDanhMucPhuCapRepository, DanhMucPhuCapRepository>();
            services.AddTransient<IDanhMucToChucDaoTaoRepository, DanhMucToChucDaoTaoRepository>();
            services.AddTransient<IDanhMucChamCongRepository, DanhMucChamCongRepository>();
            services.AddTransient<IDanhMucGiamTruRepository, DanhMucGiamTruRepository>();
            services.AddTransient<IDanhMucHopDongRepository, DanhMucHopDongRepository>();
            services.AddTransient<IDanhMucLuongCoBanRepository, DanhMucLuongCoBanRepository>();
            services.AddTransient<IDanhMucNganHangRepository, DanhMucNganHangRepository>();
            services.AddTransient<IDanhMucThueRepository, DanhMucThueRepository>();
            services.AddTransient<IDanhMucDonViTinhRepository, DanhMucDonViTinhRepository>();
            services.AddTransient<IDanhMucMayChamCongRepository, DanhMucMayChamCongRepository>();

            services.AddTransient<IHRBangLuongRepository, HRBangLuongRepository>();
            services.AddTransient<IHRBangLuongChiTietRepository, HRBangLuongChiTietRepository>();
            services.AddTransient<IHRChamCongRepository, HRChamCongRepository>();
            services.AddTransient<IHRChamCongChiTietRepository, HRChamCongChiTietRepository>();
            services.AddTransient<IHRLichCongTacRepository, HRLichCongTacRepository>();
            services.AddTransient<IHRLichCongTacChiTietRepository, HRLichCongTacChiTietRepository>();
            services.AddTransient<IHRNhanVienRepository, HRNhanVienRepository>();
            services.AddTransient<IHRNhanVienBangCapRepository, HRNhanVienBangCapRepository>();
            services.AddTransient<IHRNhanVienHopDongRepository, HRNhanVienHopDongRepository>();
            services.AddTransient<IHRNhanVienNganHangRepository, HRNhanVienNganHangRepository>();
            services.AddTransient<IHRNhanVienPhuCapRepository, HRNhanVienPhuCapRepository>();
            services.AddTransient<IHRNhanVienTapTinDinhKemRepository, HRNhanVienTapTinDinhKemRepository>();
            services.AddTransient<IHRNhanVienThanhVienRepository, HRNhanVienThanhVienRepository>();

            services.AddTransient<IDanhMucBenhVienRepository, DanhMucBenhVienRepository>();            
            services.AddTransient<IDanhMucChucNangRepository, DanhMucChucNangRepository>();            
            services.AddTransient<IDanhMucThanhVienRepository, DanhMucThanhVienRepository>();
            services.AddTransient<IDanhMucTinhTrangRepository, DanhMucTinhTrangRepository>();
            services.AddTransient<IDanhMucBieuMauRepository, DanhMucBieuMauRepository>();
            services.AddTransient<IDanhMucHinhThucThanhToanRepository, DanhMucHinhThucThanhToanRepository>();
            services.AddTransient<IDanhMucUngDungRepository, DanhMucUngDungRepository>();
            services.AddTransient<IDanhMucMauSacRepository, DanhMucMauSacRepository>();
            services.AddTransient<IDanhMucQuanHuyenRepository, DanhMucQuanHuyenRepository>();
            services.AddTransient<IDanhMucQuocGiaRepository, DanhMucQuocGiaRepository>();
            services.AddTransient<IDanhMucTinhThanhRepository, DanhMucTinhThanhRepository>();
            services.AddTransient<IDanhMucTinhThanhToaDoRepository, DanhMucTinhThanhToaDoRepository>();
            services.AddTransient<IDanhMucXaPhuongRepository, DanhMucXaPhuongRepository>();

            services.AddTransient<IDanhMucDichVuRepository, DanhMucDichVuRepository>();
            services.AddTransient<IDanhMucKhuVucRepository, DanhMucKhuVucRepository>();
            services.AddTransient<IDanhMucPhongKhamRepository, DanhMucPhongKhamRepository>();
            services.AddTransient<IDanhMucQuayDichVuRepository, DanhMucQuayDichVuRepository>();
            services.AddTransient<IDanhMucKhoaChuyenMonRepository, DanhMucKhoaChuyenMonRepository>();

            services.AddTransient<IThanhVienChucNangRepository, ThanhVienChucNangRepository>();
            services.AddTransient<IThanhVienLichSuTruyCapRepository, ThanhVienLichSuTruyCapRepository>();
            services.AddTransient<IThanhVienRepository, ThanhVienRepository>();
            services.AddTransient<IThanhVienTokenRepository, ThanhVienTokenRepository>();
            services.AddTransient<IThanhVienUngDungRepository, ThanhVienUngDungRepository>();
            services.AddTransient<IThanhVienDichVuRepository, ThanhVienDichVuRepository>();
            services.AddTransient<IThanhVienPhongKhamRepository, ThanhVienPhongKhamRepository>();
            services.AddTransient<IThanhVienQuayDichVuRepository, ThanhVienQuayDichVuRepository>();

            services.AddTransient<ICongViecRepository, CongViecRepository>();
            services.AddTransient<ICongViecTapTinDinhKemRepository, CongViecTapTinDinhKemRepository>();

            services.AddTransient<IToChucRepository, ToChucRepository>();
            services.AddTransient<IToChucTaiKhoanRepository, ToChucTaiKhoanRepository>();

            services.AddTransient<IKhachHangRepository, KhachHangRepository>();

            //services.AddTransient<IDuAnRepository, DuAnRepository>();
            //services.AddTransient<IDuAnTapTinDinhKemRepository, DuAnTapTinDinhKemRepository>();
            //services.AddTransient<IDuAnThuChiRepository, DuAnThuChiRepository>();
            //services.AddTransient<IDuAnQuyetDinhRepository, DuAnQuyetDinhRepository>();
            //services.AddTransient<IDuAnQuyetToanRepository, DuAnQuyetToanRepository>();
            //services.AddTransient<IDuAnQuyetToanLuyKeRepository, DuAnQuyetToanLuyKeRepository>();
            //services.AddTransient<IDuAnQuyetToanPhanKyRepository, DuAnQuyetToanPhanKyRepository>();

            services.AddTransient<IGoiSoRepository, GoiSoRepository>();
            services.AddTransient<IGoiSoChiTietRepository, GoiSoChiTietRepository>();
            services.AddTransient<IGoiSoChiTietICDRepository, GoiSoChiTietICDRepository>();
            services.AddTransient<IGoiSoChiTietPhongKhamRepository, GoiSoChiTietPhongKhamRepository>();
            services.AddTransient<IGoiSoThamSoRepository, GoiSoThamSoRepository>();

            services.AddTransient<IManHinhTapTinDinhKemRepository, ManHinhTapTinDinhKemRepository>();
            services.AddTransient<IManHinhThongBaoRepository, ManHinhThongBaoRepository>();

            services.AddTransient<ITaiLieuRepository, TaiLieuRepository>();

            services.AddTransient<IZaloTokenRepository, ZaloTokenRepository>();
            services.AddTransient<IZaloZNSRepository, ZaloZNSRepository>();

            services.AddTransient<IKhamSucKhoeRepository, KhamSucKhoeRepository>();
            services.AddTransient<IKhamSucKhoeKetQuaRepository, KhamSucKhoeKetQuaRepository>();

            services.AddTransient<ITrucBanNhatKyRepository, TrucBanNhatKyRepository>();
            services.AddTransient<IQuanLyCongViecRepository, QuanLyCongViecRepository>();

            services.AddTransient<IReportRepository, ReportRepository>();

            return services;
        }      
    }
}
