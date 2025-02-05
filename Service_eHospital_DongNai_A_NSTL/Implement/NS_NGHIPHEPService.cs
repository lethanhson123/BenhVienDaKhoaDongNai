namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NGHIPHEPService : BaseService<NS_NGHIPHEP, INS_NGHIPHEPRepository>
    , INS_NGHIPHEPService
    {
    private readonly INS_NGHIPHEPRepository _NS_NGHIPHEPRepository;
    public NS_NGHIPHEPService(INS_NGHIPHEPRepository NS_NGHIPHEPRepository) : base(NS_NGHIPHEPRepository)
    {
    _NS_NGHIPHEPRepository = NS_NGHIPHEPRepository;
    }
    }
    }

