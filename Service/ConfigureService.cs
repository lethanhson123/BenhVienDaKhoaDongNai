using Data.Model;
using Repository.Implement;
using Repository.Interface;
using Service.Implement;
using Service.Interface;

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
            services.AddTransient<IDanhMucBenhVienService, DanhMucBenhVienService>();
            services.AddTransient<IDanhMucChucDanhService, DanhMucChucDanhService>();
            services.AddTransient<IDanhMucChucNangService, DanhMucChucNangService>();
            services.AddTransient<IDanhMucPhongBanService, DanhMucPhongBanService>();
            services.AddTransient<IDanhMucThanhVienService, DanhMucThanhVienService>();
            services.AddTransient<IDanhMucTinhTrangService, DanhMucTinhTrangService>();
            services.AddTransient<IDanhMucBieuMauService, DanhMucBieuMauService>();
            services.AddTransient<IDanhMucHinhThucThanhToanService, DanhMucHinhThucThanhToanService>();

            services.AddTransient<IThanhVienChucNangService, ThanhVienChucNangService>();
            services.AddTransient<IThanhVienLichSuTruyCapService, ThanhVienLichSuTruyCapService>();
            services.AddTransient<IThanhVienService, ThanhVienService>();
            services.AddTransient<IThanhVienTokenService, ThanhVienTokenService>();

            services.AddTransient<ICongViecService, CongViecService>();
            services.AddTransient<ICongViecTapTinDinhKemService, CongViecTapTinDinhKemService>();

            services.AddTransient<IToChucService, ToChucService>();
            services.AddTransient<IToChucTaiKhoanService, ToChucTaiKhoanService>();

            services.AddTransient<IDuAnService, DuAnService>();
            services.AddTransient<IDuAnTapTinDinhKemService, DuAnTapTinDinhKemService>();
            services.AddTransient<IDuAnThuChiService, DuAnThuChiService>();
            services.AddTransient<IDuAnQuyetDinhService, DuAnQuyetDinhService>();
            services.AddTransient<IDuAnQuyetToanService, DuAnQuyetToanService>();


            services.AddSingleton(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IDanhMucBenhVienRepository, DanhMucBenhVienRepository>();
            services.AddTransient<IDanhMucChucDanhRepository, DanhMucChucDanhRepository>();
            services.AddTransient<IDanhMucChucNangRepository, DanhMucChucNangRepository>();
            services.AddTransient<IDanhMucPhongBanRepository, DanhMucPhongBanRepository>();
            services.AddTransient<IDanhMucThanhVienRepository, DanhMucThanhVienRepository>();
            services.AddTransient<IDanhMucTinhTrangRepository, DanhMucTinhTrangRepository>();
            services.AddTransient<IDanhMucBieuMauRepository, DanhMucBieuMauRepository>();
            services.AddTransient<IDanhMucHinhThucThanhToanRepository, DanhMucHinhThucThanhToanRepository>();

            services.AddTransient<IThanhVienChucNangRepository, ThanhVienChucNangRepository>();
            services.AddTransient<IThanhVienLichSuTruyCapRepository, ThanhVienLichSuTruyCapRepository>();
            services.AddTransient<IThanhVienRepository, ThanhVienRepository>();
            services.AddTransient<IThanhVienTokenRepository, ThanhVienTokenRepository>();

            services.AddTransient<ICongViecRepository, CongViecRepository>();
            services.AddTransient<ICongViecTapTinDinhKemRepository, CongViecTapTinDinhKemRepository>();

            services.AddTransient<IToChucRepository, ToChucRepository>();
            services.AddTransient<IToChucTaiKhoanRepository, ToChucTaiKhoanRepository>();

            services.AddTransient<IDuAnRepository, DuAnRepository>();
            services.AddTransient<IDuAnTapTinDinhKemRepository, DuAnTapTinDinhKemRepository>();
            services.AddTransient<IDuAnThuChiRepository, DuAnThuChiRepository>();
            services.AddTransient<IDuAnQuyetDinhRepository, DuAnQuyetDinhRepository>();
            services.AddTransient<IDuAnQuyetToanRepository, DuAnQuyetToanRepository>();

            return services;
        }
    }
}
