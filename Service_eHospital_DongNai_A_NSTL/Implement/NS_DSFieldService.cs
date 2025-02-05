namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DSFieldService : BaseService<NS_DSField, INS_DSFieldRepository>
    , INS_DSFieldService
    {
    private readonly INS_DSFieldRepository _NS_DSFieldRepository;
    public NS_DSFieldService(INS_DSFieldRepository NS_DSFieldRepository) : base(NS_DSFieldRepository)
    {
    _NS_DSFieldRepository = NS_DSFieldRepository;
    }
    }
    }

