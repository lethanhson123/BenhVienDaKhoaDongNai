namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NhanVien_PhongBanService : BaseService<NS_NhanVien_PhongBan, INS_NhanVien_PhongBanRepository>
    , INS_NhanVien_PhongBanService
    {
    private readonly INS_NhanVien_PhongBanRepository _NS_NhanVien_PhongBanRepository;
    public NS_NhanVien_PhongBanService(INS_NhanVien_PhongBanRepository NS_NhanVien_PhongBanRepository) : base(NS_NhanVien_PhongBanRepository)
    {
    _NS_NhanVien_PhongBanRepository = NS_NhanVien_PhongBanRepository;
    }
    }
    }

