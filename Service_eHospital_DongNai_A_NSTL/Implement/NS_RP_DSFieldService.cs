namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_RP_DSFieldService : BaseService<NS_RP_DSField, INS_RP_DSFieldRepository>
    , INS_RP_DSFieldService
    {
    private readonly INS_RP_DSFieldRepository _NS_RP_DSFieldRepository;
    public NS_RP_DSFieldService(INS_RP_DSFieldRepository NS_RP_DSFieldRepository) : base(NS_RP_DSFieldRepository)
    {
    _NS_RP_DSFieldRepository = NS_RP_DSFieldRepository;
    }
    }
    }

