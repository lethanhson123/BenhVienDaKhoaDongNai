namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TONGIAOService : BaseService<NS_DM_TONGIAO, INS_DM_TONGIAORepository>
    , INS_DM_TONGIAOService
    {
    private readonly INS_DM_TONGIAORepository _NS_DM_TONGIAORepository;
    public NS_DM_TONGIAOService(INS_DM_TONGIAORepository NS_DM_TONGIAORepository) : base(NS_DM_TONGIAORepository)
    {
    _NS_DM_TONGIAORepository = NS_DM_TONGIAORepository;
    }
    }
    }

