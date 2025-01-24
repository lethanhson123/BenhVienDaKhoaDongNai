namespace Service_eHospital_DongNai_A.Implement
{
    public class TinSMSService : BaseService<TinSMS, ITinSMSRepository>
    , ITinSMSService
    {
    private readonly ITinSMSRepository _TinSMSRepository;
    public TinSMSService(ITinSMSRepository TinSMSRepository) : base(TinSMSRepository)
    {
    _TinSMSRepository = TinSMSRepository;
    }
    }
    }

