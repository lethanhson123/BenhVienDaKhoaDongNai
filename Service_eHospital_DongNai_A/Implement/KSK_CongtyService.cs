namespace Service_eHospital_DongNai_A.Implement
{
    public class KSK_CongtyService : BaseService<KSK_Congty, IKSK_CongtyRepository>
    , IKSK_CongtyService
    {
    private readonly IKSK_CongtyRepository _KSK_CongtyRepository;
    public KSK_CongtyService(IKSK_CongtyRepository KSK_CongtyRepository) : base(KSK_CongtyRepository)
    {
    _KSK_CongtyRepository = KSK_CongtyRepository;
    }
    }
    }

