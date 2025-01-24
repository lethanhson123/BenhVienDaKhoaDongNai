namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_TangLanKhamService : BaseService<CSKH_The_TangLanKham, ICSKH_The_TangLanKhamRepository>
    , ICSKH_The_TangLanKhamService
    {
    private readonly ICSKH_The_TangLanKhamRepository _CSKH_The_TangLanKhamRepository;
    public CSKH_The_TangLanKhamService(ICSKH_The_TangLanKhamRepository CSKH_The_TangLanKhamRepository) : base(CSKH_The_TangLanKhamRepository)
    {
    _CSKH_The_TangLanKhamRepository = CSKH_The_TangLanKhamRepository;
    }
    }
    }

