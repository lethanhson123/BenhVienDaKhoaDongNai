namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class ZZZ_NhanVienSOBHXHService : BaseService<ZZZ_NhanVienSOBHXH, IZZZ_NhanVienSOBHXHRepository>
    , IZZZ_NhanVienSOBHXHService
    {
    private readonly IZZZ_NhanVienSOBHXHRepository _ZZZ_NhanVienSOBHXHRepository;
    public ZZZ_NhanVienSOBHXHService(IZZZ_NhanVienSOBHXHRepository ZZZ_NhanVienSOBHXHRepository) : base(ZZZ_NhanVienSOBHXHRepository)
    {
    _ZZZ_NhanVienSOBHXHRepository = ZZZ_NhanVienSOBHXHRepository;
    }
    }
    }

