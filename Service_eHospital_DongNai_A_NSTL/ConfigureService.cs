namespace Service_eHospital_DongNai_A_NSTL
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
            services.AddDbContext<Context>
    (opts =>
    {
    });
    return services;
    }
    public static IServiceCollection AddService(this IServiceCollection services)
    {
    services.AddTransient<IChamCongService, ChamCongService>();
services.AddTransient<IDatabaseLogService, DatabaseLogService>();
services.AddTransient<IDM_NgachBac_ExcelService, DM_NgachBac_ExcelService>();
services.AddTransient<IDM_NhanVienExcelService, DM_NhanVienExcelService>();
services.AddTransient<IdtpropertiesService, dtpropertiesService>();
services.AddTransient<INS_BANGCAPService, NS_BANGCAPService>();
services.AddTransient<INS_BANGCAP_BK20171228Service, NS_BANGCAP_BK20171228Service>();
services.AddTransient<INS_BANGCAP_UVService, NS_BANGCAP_UVService>();
services.AddTransient<INS_CHAMCONGService, NS_CHAMCONGService>();
services.AddTransient<INS_CONGTACService, NS_CONGTACService>();
services.AddTransient<INS_CONGTAC_UVService, NS_CONGTAC_UVService>();
services.AddTransient<INS_DAOTAOService, NS_DAOTAOService>();
services.AddTransient<INS_DeNghiKhenThuongService, NS_DeNghiKhenThuongService>();
services.AddTransient<INS_DIEUCHUYENService, NS_DIEUCHUYENService>();
services.AddTransient<INS_DM_BacLuongService, NS_DM_BacLuongService>();
services.AddTransient<INS_DM_BieuThueTNCNService, NS_DM_BieuThueTNCNService>();
services.AddTransient<INS_DM_CaTrucService, NS_DM_CaTrucService>();
services.AddTransient<INS_DM_CHUCDANH_Service, NS_DM_CHUCDANH_Service>();
services.AddTransient<INS_DM_CHUCVU_Service, NS_DM_CHUCVU_Service>();
services.AddTransient<INS_DM_CHUYENNGANHService, NS_DM_CHUYENNGANHService>();
services.AddTransient<INS_DM_DANTOC_Service, NS_DM_DANTOC_Service>();
services.AddTransient<INS_DM_DAOTAOService, NS_DM_DAOTAOService>();
services.AddTransient<INS_DM_DinhSuatService, NS_DM_DinhSuatService>();
services.AddTransient<INS_DM_HopDongService, NS_DM_HopDongService>();
services.AddTransient<INS_DM_LoaiTrucService, NS_DM_LoaiTrucService>();
services.AddTransient<INS_DM_LoaiTruc_NgoaiGioService, NS_DM_LoaiTruc_NgoaiGioService>();
services.AddTransient<INS_DM_LYDONGHIPHEPService, NS_DM_LYDONGHIPHEPService>();
services.AddTransient<INS_DM_LyDoNghiViecService, NS_DM_LyDoNghiViecService>();
services.AddTransient<INS_DM_LYDOVANGMATService, NS_DM_LYDOVANGMATService>();
services.AddTransient<INS_DM_MucHuongDocHaiService, NS_DM_MucHuongDocHaiService>();
services.AddTransient<INS_DM_NgachLuongService, NS_DM_NgachLuongService>();
services.AddTransient<INS_DM_NGAYLEService, NS_DM_NGAYLEService>();
services.AddTransient<INS_DM_NGHENGHIEPService, NS_DM_NGHENGHIEPService>();
services.AddTransient<INS_DM_NHOMService, NS_DM_NHOMService>();
services.AddTransient<INS_DM_PHONGBAN_Service, NS_DM_PHONGBAN_Service>();
services.AddTransient<INS_DM_PhuCapService, NS_DM_PhuCapService>();
services.AddTransient<INS_DM_PHUCAPTRUCService, NS_DM_PHUCAPTRUCService>();
services.AddTransient<INS_DM_QUANHEService, NS_DM_QUANHEService>();
services.AddTransient<INS_DM_QUANHUYENService, NS_DM_QUANHUYENService>();
services.AddTransient<INS_DM_QUOCTICH_Service, NS_DM_QUOCTICH_Service>();
services.AddTransient<INS_DM_TenDanhHieuThiDuaService, NS_DM_TenDanhHieuThiDuaService>();
services.AddTransient<INS_DM_ThoiGianDiHocService, NS_DM_ThoiGianDiHocService>();
services.AddTransient<INS_DM_TINHService, NS_DM_TINHService>();
services.AddTransient<INS_DM_TinhTrangQuanHeService, NS_DM_TinhTrangQuanHeService>();
services.AddTransient<INS_DM_TONGIAOService, NS_DM_TONGIAOService>();
services.AddTransient<INS_DM_TRINHDOService, NS_DM_TRINHDOService>();
services.AddTransient<INS_DM_TRINHDOCHUYENMON_Service, NS_DM_TRINHDOCHUYENMON_Service>();
services.AddTransient<INS_DM_TRINHDONGOAINGUService, NS_DM_TRINHDONGOAINGUService>();
services.AddTransient<INS_DSFieldService, NS_DSFieldService>();
services.AddTransient<INS_DSTableService, NS_DSTableService>();
services.AddTransient<INS_GIAHANHOPDONGService, NS_GIAHANHOPDONGService>();
services.AddTransient<INS_HOPDONGLAODONGService, NS_HOPDONGLAODONGService>();
services.AddTransient<INS_KHENTHUONGKYLUATService, NS_KHENTHUONGKYLUATService>();
services.AddTransient<INS_KhoaBangChamCongService, NS_KhoaBangChamCongService>();
services.AddTransient<INS_KhoaBangLuongService, NS_KhoaBangLuongService>();
services.AddTransient<INS_KINHNGHIEMCHUYENMONService, NS_KINHNGHIEMCHUYENMONService>();
services.AddTransient<INS_L_CHAMCONGVANGService, NS_L_CHAMCONGVANGService>();
services.AddTransient<INS_L_CHITIEU_NVService, NS_L_CHITIEU_NVService>();
services.AddTransient<INS_L_DMCHITIEUService, NS_L_DMCHITIEUService>();
services.AddTransient<INS_LICHTRUCService, NS_LICHTRUCService>();
services.AddTransient<INS_NGACHBACLUONGService, NS_NGACHBACLUONGService>();
services.AddTransient<INS_NGHIPHEPService, NS_NGHIPHEPService>();
services.AddTransient<INS_NGOAINGUService, NS_NGOAINGUService>();
services.AddTransient<INS_NGOAINGU_UVService, NS_NGOAINGU_UVService>();
services.AddTransient<INS_NHANVIENService, NS_NHANVIENService>();
services.AddTransient<INS_NhanVien_Lich_CaTrucService, NS_NhanVien_Lich_CaTrucService>();
services.AddTransient<INS_NhanVien_NhanVienService, NS_NhanVien_NhanVienService>();
services.AddTransient<INS_NhanVien_PhongBanService, NS_NhanVien_PhongBanService>();
services.AddTransient<INS_PHEPNAMService, NS_PHEPNAMService>();
services.AddTransient<INS_PhongBan_DinhSuatService, NS_PhongBan_DinhSuatService>();
services.AddTransient<INS_QUANHEGIADINHService, NS_QUANHEGIADINHService>();
services.AddTransient<INS_RP_DSFieldService, NS_RP_DSFieldService>();
services.AddTransient<INS_RP_DSOperatorService, NS_RP_DSOperatorService>();
services.AddTransient<INS_RP_DSQueryService, NS_RP_DSQueryService>();
services.AddTransient<INS_RP_DSTableService, NS_RP_DSTableService>();
services.AddTransient<INS_RP_FILTERService, NS_RP_FILTERService>();
services.AddTransient<INS_RP_FORMULARSService, NS_RP_FORMULARSService>();
services.AddTransient<INS_RP_LSTFILTERService, NS_RP_LSTFILTERService>();
services.AddTransient<INS_RP_LSTREPORTService, NS_RP_LSTREPORTService>();
services.AddTransient<INS_RP_LSTSUBREPORTService, NS_RP_LSTSUBREPORTService>();
services.AddTransient<INS_SYS_HANGSOService, NS_SYS_HANGSOService>();
services.AddTransient<INS_SYS_tblFunctionListService, NS_SYS_tblFunctionListService>();
services.AddTransient<INS_ThiDuaService, NS_ThiDuaService>();
services.AddTransient<INS_THONGTINUNGVIENService, NS_THONGTINUNGVIENService>();
services.AddTransient<INS_TUYENDUNGService, NS_TUYENDUNGService>();
services.AddTransient<INS_XepLichTrucService, NS_XepLichTrucService>();
services.AddTransient<INS_XepLichTruc_NgoaiGioService, NS_XepLichTruc_NgoaiGioService>();
services.AddTransient<IsysdiagramsService, sysdiagramsService>();
services.AddTransient<IT_FK_XrefService, T_FK_XrefService>();
services.AddTransient<IThongTinChamCongService, ThongTinChamCongService>();
services.AddTransient<Iz_ImportService, z_ImportService>();
services.AddTransient<IzTemp_NV_excelService, zTemp_NV_excelService>();
services.AddTransient<IZZZ_NhanVienSOBHXHService, ZZZ_NhanVienSOBHXHService>();
services.AddTransient<IzzzNhanVien_2023_05_23Service, zzzNhanVien_2023_05_23Service>();

    services.AddSingleton(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));
    return services;
    }

    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
    services.AddTransient<IChamCongRepository, ChamCongRepository>();
services.AddTransient<IDatabaseLogRepository, DatabaseLogRepository>();
services.AddTransient<IDM_NgachBac_ExcelRepository, DM_NgachBac_ExcelRepository>();
services.AddTransient<IDM_NhanVienExcelRepository, DM_NhanVienExcelRepository>();
services.AddTransient<IdtpropertiesRepository, dtpropertiesRepository>();
services.AddTransient<INS_BANGCAPRepository, NS_BANGCAPRepository>();
services.AddTransient<INS_BANGCAP_BK20171228Repository, NS_BANGCAP_BK20171228Repository>();
services.AddTransient<INS_BANGCAP_UVRepository, NS_BANGCAP_UVRepository>();
services.AddTransient<INS_CHAMCONGRepository, NS_CHAMCONGRepository>();
services.AddTransient<INS_CONGTACRepository, NS_CONGTACRepository>();
services.AddTransient<INS_CONGTAC_UVRepository, NS_CONGTAC_UVRepository>();
services.AddTransient<INS_DAOTAORepository, NS_DAOTAORepository>();
services.AddTransient<INS_DeNghiKhenThuongRepository, NS_DeNghiKhenThuongRepository>();
services.AddTransient<INS_DIEUCHUYENRepository, NS_DIEUCHUYENRepository>();
services.AddTransient<INS_DM_BacLuongRepository, NS_DM_BacLuongRepository>();
services.AddTransient<INS_DM_BieuThueTNCNRepository, NS_DM_BieuThueTNCNRepository>();
services.AddTransient<INS_DM_CaTrucRepository, NS_DM_CaTrucRepository>();
services.AddTransient<INS_DM_CHUCDANH_Repository, NS_DM_CHUCDANH_Repository>();
services.AddTransient<INS_DM_CHUCVU_Repository, NS_DM_CHUCVU_Repository>();
services.AddTransient<INS_DM_CHUYENNGANHRepository, NS_DM_CHUYENNGANHRepository>();
services.AddTransient<INS_DM_DANTOC_Repository, NS_DM_DANTOC_Repository>();
services.AddTransient<INS_DM_DAOTAORepository, NS_DM_DAOTAORepository>();
services.AddTransient<INS_DM_DinhSuatRepository, NS_DM_DinhSuatRepository>();
services.AddTransient<INS_DM_HopDongRepository, NS_DM_HopDongRepository>();
services.AddTransient<INS_DM_LoaiTrucRepository, NS_DM_LoaiTrucRepository>();
services.AddTransient<INS_DM_LoaiTruc_NgoaiGioRepository, NS_DM_LoaiTruc_NgoaiGioRepository>();
services.AddTransient<INS_DM_LYDONGHIPHEPRepository, NS_DM_LYDONGHIPHEPRepository>();
services.AddTransient<INS_DM_LyDoNghiViecRepository, NS_DM_LyDoNghiViecRepository>();
services.AddTransient<INS_DM_LYDOVANGMATRepository, NS_DM_LYDOVANGMATRepository>();
services.AddTransient<INS_DM_MucHuongDocHaiRepository, NS_DM_MucHuongDocHaiRepository>();
services.AddTransient<INS_DM_NgachLuongRepository, NS_DM_NgachLuongRepository>();
services.AddTransient<INS_DM_NGAYLERepository, NS_DM_NGAYLERepository>();
services.AddTransient<INS_DM_NGHENGHIEPRepository, NS_DM_NGHENGHIEPRepository>();
services.AddTransient<INS_DM_NHOMRepository, NS_DM_NHOMRepository>();
services.AddTransient<INS_DM_PHONGBAN_Repository, NS_DM_PHONGBAN_Repository>();
services.AddTransient<INS_DM_PhuCapRepository, NS_DM_PhuCapRepository>();
services.AddTransient<INS_DM_PHUCAPTRUCRepository, NS_DM_PHUCAPTRUCRepository>();
services.AddTransient<INS_DM_QUANHERepository, NS_DM_QUANHERepository>();
services.AddTransient<INS_DM_QUANHUYENRepository, NS_DM_QUANHUYENRepository>();
services.AddTransient<INS_DM_QUOCTICH_Repository, NS_DM_QUOCTICH_Repository>();
services.AddTransient<INS_DM_TenDanhHieuThiDuaRepository, NS_DM_TenDanhHieuThiDuaRepository>();
services.AddTransient<INS_DM_ThoiGianDiHocRepository, NS_DM_ThoiGianDiHocRepository>();
services.AddTransient<INS_DM_TINHRepository, NS_DM_TINHRepository>();
services.AddTransient<INS_DM_TinhTrangQuanHeRepository, NS_DM_TinhTrangQuanHeRepository>();
services.AddTransient<INS_DM_TONGIAORepository, NS_DM_TONGIAORepository>();
services.AddTransient<INS_DM_TRINHDORepository, NS_DM_TRINHDORepository>();
services.AddTransient<INS_DM_TRINHDOCHUYENMON_Repository, NS_DM_TRINHDOCHUYENMON_Repository>();
services.AddTransient<INS_DM_TRINHDONGOAINGURepository, NS_DM_TRINHDONGOAINGURepository>();
services.AddTransient<INS_DSFieldRepository, NS_DSFieldRepository>();
services.AddTransient<INS_DSTableRepository, NS_DSTableRepository>();
services.AddTransient<INS_GIAHANHOPDONGRepository, NS_GIAHANHOPDONGRepository>();
services.AddTransient<INS_HOPDONGLAODONGRepository, NS_HOPDONGLAODONGRepository>();
services.AddTransient<INS_KHENTHUONGKYLUATRepository, NS_KHENTHUONGKYLUATRepository>();
services.AddTransient<INS_KhoaBangChamCongRepository, NS_KhoaBangChamCongRepository>();
services.AddTransient<INS_KhoaBangLuongRepository, NS_KhoaBangLuongRepository>();
services.AddTransient<INS_KINHNGHIEMCHUYENMONRepository, NS_KINHNGHIEMCHUYENMONRepository>();
services.AddTransient<INS_L_CHAMCONGVANGRepository, NS_L_CHAMCONGVANGRepository>();
services.AddTransient<INS_L_CHITIEU_NVRepository, NS_L_CHITIEU_NVRepository>();
services.AddTransient<INS_L_DMCHITIEURepository, NS_L_DMCHITIEURepository>();
services.AddTransient<INS_LICHTRUCRepository, NS_LICHTRUCRepository>();
services.AddTransient<INS_NGACHBACLUONGRepository, NS_NGACHBACLUONGRepository>();
services.AddTransient<INS_NGHIPHEPRepository, NS_NGHIPHEPRepository>();
services.AddTransient<INS_NGOAINGURepository, NS_NGOAINGURepository>();
services.AddTransient<INS_NGOAINGU_UVRepository, NS_NGOAINGU_UVRepository>();
services.AddTransient<INS_NHANVIENRepository, NS_NHANVIENRepository>();
services.AddTransient<INS_NhanVien_Lich_CaTrucRepository, NS_NhanVien_Lich_CaTrucRepository>();
services.AddTransient<INS_NhanVien_NhanVienRepository, NS_NhanVien_NhanVienRepository>();
services.AddTransient<INS_NhanVien_PhongBanRepository, NS_NhanVien_PhongBanRepository>();
services.AddTransient<INS_PHEPNAMRepository, NS_PHEPNAMRepository>();
services.AddTransient<INS_PhongBan_DinhSuatRepository, NS_PhongBan_DinhSuatRepository>();
services.AddTransient<INS_QUANHEGIADINHRepository, NS_QUANHEGIADINHRepository>();
services.AddTransient<INS_RP_DSFieldRepository, NS_RP_DSFieldRepository>();
services.AddTransient<INS_RP_DSOperatorRepository, NS_RP_DSOperatorRepository>();
services.AddTransient<INS_RP_DSQueryRepository, NS_RP_DSQueryRepository>();
services.AddTransient<INS_RP_DSTableRepository, NS_RP_DSTableRepository>();
services.AddTransient<INS_RP_FILTERRepository, NS_RP_FILTERRepository>();
services.AddTransient<INS_RP_FORMULARSRepository, NS_RP_FORMULARSRepository>();
services.AddTransient<INS_RP_LSTFILTERRepository, NS_RP_LSTFILTERRepository>();
services.AddTransient<INS_RP_LSTREPORTRepository, NS_RP_LSTREPORTRepository>();
services.AddTransient<INS_RP_LSTSUBREPORTRepository, NS_RP_LSTSUBREPORTRepository>();
services.AddTransient<INS_SYS_HANGSORepository, NS_SYS_HANGSORepository>();
services.AddTransient<INS_SYS_tblFunctionListRepository, NS_SYS_tblFunctionListRepository>();
services.AddTransient<INS_ThiDuaRepository, NS_ThiDuaRepository>();
services.AddTransient<INS_THONGTINUNGVIENRepository, NS_THONGTINUNGVIENRepository>();
services.AddTransient<INS_TUYENDUNGRepository, NS_TUYENDUNGRepository>();
services.AddTransient<INS_XepLichTrucRepository, NS_XepLichTrucRepository>();
services.AddTransient<INS_XepLichTruc_NgoaiGioRepository, NS_XepLichTruc_NgoaiGioRepository>();
services.AddTransient<IsysdiagramsRepository, sysdiagramsRepository>();
services.AddTransient<IT_FK_XrefRepository, T_FK_XrefRepository>();
services.AddTransient<IThongTinChamCongRepository, ThongTinChamCongRepository>();
services.AddTransient<Iz_ImportRepository, z_ImportRepository>();
services.AddTransient<IzTemp_NV_excelRepository, zTemp_NV_excelRepository>();
services.AddTransient<IZZZ_NhanVienSOBHXHRepository, ZZZ_NhanVienSOBHXHRepository>();
services.AddTransient<IzzzNhanVien_2023_05_23Repository, zzzNhanVien_2023_05_23Repository>();

    return services;
    }
    }
    }

