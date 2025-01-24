namespace Service_eHospital_DongNai_A.Implement
{
    public class BENHNHAN_THEATMService : BaseService<BENHNHAN_THEATM, IBENHNHAN_THEATMRepository>
    , IBENHNHAN_THEATMService
    {
    private readonly IBENHNHAN_THEATMRepository _BENHNHAN_THEATMRepository;
    public BENHNHAN_THEATMService(IBENHNHAN_THEATMRepository BENHNHAN_THEATMRepository) : base(BENHNHAN_THEATMRepository)
    {
    _BENHNHAN_THEATMRepository = BENHNHAN_THEATMRepository;
    }
    }
    }

