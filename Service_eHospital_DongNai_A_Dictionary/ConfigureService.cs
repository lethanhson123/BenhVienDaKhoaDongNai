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

            return services;
        }      
    }
}
