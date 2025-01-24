namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_NapTienService : BaseService<CSKH_The_NapTien, ICSKH_The_NapTienRepository>
    , ICSKH_The_NapTienService
    {
    private readonly ICSKH_The_NapTienRepository _CSKH_The_NapTienRepository;
    public CSKH_The_NapTienService(ICSKH_The_NapTienRepository CSKH_The_NapTienRepository) : base(CSKH_The_NapTienRepository)
    {
    _CSKH_The_NapTienRepository = CSKH_The_NapTienRepository;
    }
    }
    }

