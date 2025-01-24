namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_KhuyenMaiNapTienService : BaseService<CSKH_The_KhuyenMaiNapTien, ICSKH_The_KhuyenMaiNapTienRepository>
    , ICSKH_The_KhuyenMaiNapTienService
    {
    private readonly ICSKH_The_KhuyenMaiNapTienRepository _CSKH_The_KhuyenMaiNapTienRepository;
    public CSKH_The_KhuyenMaiNapTienService(ICSKH_The_KhuyenMaiNapTienRepository CSKH_The_KhuyenMaiNapTienRepository) : base(CSKH_The_KhuyenMaiNapTienRepository)
    {
    _CSKH_The_KhuyenMaiNapTienRepository = CSKH_The_KhuyenMaiNapTienRepository;
    }
    }
    }

