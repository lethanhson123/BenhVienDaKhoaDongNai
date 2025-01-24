namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_TangTienService : BaseService<CSKH_The_TangTien, ICSKH_The_TangTienRepository>
    , ICSKH_The_TangTienService
    {
    private readonly ICSKH_The_TangTienRepository _CSKH_The_TangTienRepository;
    public CSKH_The_TangTienService(ICSKH_The_TangTienRepository CSKH_The_TangTienRepository) : base(CSKH_The_TangTienRepository)
    {
    _CSKH_The_TangTienRepository = CSKH_The_TangTienRepository;
    }
    }
    }

