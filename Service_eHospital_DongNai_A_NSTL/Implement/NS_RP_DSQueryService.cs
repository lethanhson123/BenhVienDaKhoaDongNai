namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSQueryService : BaseService<NS_RP_DSQuery, INS_RP_DSQueryRepository>
    , INS_RP_DSQueryService
    {
    private readonly INS_RP_DSQueryRepository _NS_RP_DSQueryRepository;
    public NS_RP_DSQueryService(INS_RP_DSQueryRepository NS_RP_DSQueryRepository) : base(NS_RP_DSQueryRepository)
    {
    _NS_RP_DSQueryRepository = NS_RP_DSQueryRepository;
    }
    }
    }

