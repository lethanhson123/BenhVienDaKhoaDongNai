namespace Service_eHospital_DongNai_A.Implement
{
    public class MauTinSMSService : BaseService<MauTinSMS, IMauTinSMSRepository>
    , IMauTinSMSService
    {
    private readonly IMauTinSMSRepository _MauTinSMSRepository;
    public MauTinSMSService(IMauTinSMSRepository MauTinSMSRepository) : base(MauTinSMSRepository)
    {
    _MauTinSMSRepository = MauTinSMSRepository;
    }
    }
    }

