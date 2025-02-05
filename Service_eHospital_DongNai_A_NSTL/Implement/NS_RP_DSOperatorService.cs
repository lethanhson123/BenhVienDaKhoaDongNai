namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSOperatorService : BaseService<NS_RP_DSOperator, INS_RP_DSOperatorRepository>
    , INS_RP_DSOperatorService
    {
    private readonly INS_RP_DSOperatorRepository _NS_RP_DSOperatorRepository;
    public NS_RP_DSOperatorService(INS_RP_DSOperatorRepository NS_RP_DSOperatorRepository) : base(NS_RP_DSOperatorRepository)
    {
    _NS_RP_DSOperatorRepository = NS_RP_DSOperatorRepository;
    }
    }
    }

