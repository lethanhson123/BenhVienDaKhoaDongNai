namespace Service_eHospital_DongNai_A_Dictionary
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
            services.AddTransient<IDM_BenhNhan_BHYTService, DM_BenhNhan_BHYTService>();
            services.AddTransient<IDM_BenhNhanService, DM_BenhNhanService>();
            services.AddTransient<IDM_BenhVienService, DM_BenhVienService>();
            services.AddTransient<IDM_DonViHanhChinhService, DM_DonViHanhChinhService>();
            services.AddTransient<ILst_Dictionary_TypeService, Lst_Dictionary_TypeService>();
            services.AddTransient<ILst_DictionaryService, Lst_DictionaryService>();
            services.AddTransient<IDM_DichVuService, DM_DichVuService>();
            services.AddTransient<IDM_DonViTinhService, DM_DonViTinhService>();
            services.AddTransient<IDM_ICDService, DM_ICDService>();
            services.AddTransient<IDM_ICD_ChuongService, DM_ICD_ChuongService>();
            services.AddTransient<IDM_ICD_CommonService, DM_ICD_CommonService>();
            services.AddTransient<IDM_ICD_NhomService, DM_ICD_NhomService>();
            services.AddTransient<IDM_KhoDuocService, DM_KhoDuocService>();
            services.AddTransient<IDM_NhomDichVuService, DM_NhomDichVuService>();
            services.AddTransient<IDM_PhongBanService, DM_PhongBanService>();
            services.AddTransient<IDM_LoaiDichVuService, DM_LoaiDichVuService>();
            services.AddTransient<IDM_BangGiaService, DM_BangGiaService>();
            services.AddTransient<IDM_BangGia_CPHService, DM_BangGia_CPHService>();
            services.AddTransient<IDM_DichVu_DonGiaService, DM_DichVu_DonGiaService>();
            services.AddTransient<IDM_DichVu_DonGia_CPHService, DM_DichVu_DonGia_CPHService>();
            services.AddTransient<IDM_LoaiGiaService, DM_LoaiGiaService>();

            services.AddSingleton(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IDM_BenhNhan_BHYTRepository, DM_BenhNhan_BHYTRepository>();
            services.AddTransient<IDM_BenhNhanRepository, DM_BenhNhanRepository>();
            services.AddTransient<IDM_BenhVienRepository, DM_BenhVienRepository>();
            services.AddTransient<IDM_DonViHanhChinhRepository, DM_DonViHanhChinhRepository>();
            services.AddTransient<ILst_Dictionary_TypeRepository, Lst_Dictionary_TypeRepository>();
            services.AddTransient<ILst_DictionaryRepository, Lst_DictionaryRepository>();
            services.AddTransient<IDM_DichVuRepository, DM_DichVuRepository>();
            services.AddTransient<IDM_DonViTinhRepository, DM_DonViTinhRepository>();
            services.AddTransient<IDM_ICDRepository, DM_ICDRepository>();
            services.AddTransient<IDM_ICD_ChuongRepository, DM_ICD_ChuongRepository>();
            services.AddTransient<IDM_ICD_CommonRepository, DM_ICD_CommonRepository>();
            services.AddTransient<IDM_ICD_NhomRepository, DM_ICD_NhomRepository>();
            services.AddTransient<IDM_KhoDuocRepository, DM_KhoDuocRepository>();
            services.AddTransient<IDM_NhomDichVuRepository, DM_NhomDichVuRepository>();
            services.AddTransient<IDM_PhongBanRepository, DM_PhongBanRepository>();
            services.AddTransient<IDM_LoaiDichVuRepository, DM_LoaiDichVuRepository>();
            services.AddTransient<IDM_BangGiaRepository, DM_BangGiaRepository>();
            services.AddTransient<IDM_BangGia_CPHRepository, DM_BangGia_CPHRepository>();
            services.AddTransient<IDM_DichVu_DonGiaRepository, DM_DichVu_DonGiaRepository>();
            services.AddTransient<IDM_DichVu_DonGia_CPHRepository, DM_DichVu_DonGia_CPHRepository>();
            services.AddTransient<IDM_LoaiGiaRepository, DM_LoaiGiaRepository>();

            return services;
        }      
    }
}
