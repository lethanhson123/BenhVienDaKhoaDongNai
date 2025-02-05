namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_PHUCAPTRUCService : BaseService<NS_DM_PHUCAPTRUC, INS_DM_PHUCAPTRUCRepository>
    , INS_DM_PHUCAPTRUCService
    {
    private readonly INS_DM_PHUCAPTRUCRepository _NS_DM_PHUCAPTRUCRepository;
    public NS_DM_PHUCAPTRUCService(INS_DM_PHUCAPTRUCRepository NS_DM_PHUCAPTRUCRepository) : base(NS_DM_PHUCAPTRUCRepository)
    {
    _NS_DM_PHUCAPTRUCRepository = NS_DM_PHUCAPTRUCRepository;
    }
    }
    }

