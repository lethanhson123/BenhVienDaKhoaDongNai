namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_TangThePhuService : BaseService<CSKH_The_TangThePhu, ICSKH_The_TangThePhuRepository>
    , ICSKH_The_TangThePhuService
    {
    private readonly ICSKH_The_TangThePhuRepository _CSKH_The_TangThePhuRepository;
    public CSKH_The_TangThePhuService(ICSKH_The_TangThePhuRepository CSKH_The_TangThePhuRepository) : base(CSKH_The_TangThePhuRepository)
    {
    _CSKH_The_TangThePhuRepository = CSKH_The_TangThePhuRepository;
    }
    }
    }

