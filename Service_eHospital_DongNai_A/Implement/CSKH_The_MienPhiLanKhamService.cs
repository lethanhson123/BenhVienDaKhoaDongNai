namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_MienPhiLanKhamService : BaseService<CSKH_The_MienPhiLanKham, ICSKH_The_MienPhiLanKhamRepository>
    , ICSKH_The_MienPhiLanKhamService
    {
    private readonly ICSKH_The_MienPhiLanKhamRepository _CSKH_The_MienPhiLanKhamRepository;
    public CSKH_The_MienPhiLanKhamService(ICSKH_The_MienPhiLanKhamRepository CSKH_The_MienPhiLanKhamRepository) : base(CSKH_The_MienPhiLanKhamRepository)
    {
    _CSKH_The_MienPhiLanKhamRepository = CSKH_The_MienPhiLanKhamRepository;
    }
    }
    }

