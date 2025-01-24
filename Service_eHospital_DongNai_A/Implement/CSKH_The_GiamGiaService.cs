namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_GiamGiaService : BaseService<CSKH_The_GiamGia, ICSKH_The_GiamGiaRepository>
    , ICSKH_The_GiamGiaService
    {
    private readonly ICSKH_The_GiamGiaRepository _CSKH_The_GiamGiaRepository;
    public CSKH_The_GiamGiaService(ICSKH_The_GiamGiaRepository CSKH_The_GiamGiaRepository) : base(CSKH_The_GiamGiaRepository)
    {
    _CSKH_The_GiamGiaRepository = CSKH_The_GiamGiaRepository;
    }
    }
    }

