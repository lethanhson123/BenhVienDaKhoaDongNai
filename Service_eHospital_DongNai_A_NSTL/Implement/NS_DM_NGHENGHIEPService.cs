namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NGHENGHIEPService : BaseService<NS_DM_NGHENGHIEP, INS_DM_NGHENGHIEPRepository>
    , INS_DM_NGHENGHIEPService
    {
    private readonly INS_DM_NGHENGHIEPRepository _NS_DM_NGHENGHIEPRepository;
    public NS_DM_NGHENGHIEPService(INS_DM_NGHENGHIEPRepository NS_DM_NGHENGHIEPRepository) : base(NS_DM_NGHENGHIEPRepository)
    {
    _NS_DM_NGHENGHIEPRepository = NS_DM_NGHENGHIEPRepository;
    }
    }
    }

