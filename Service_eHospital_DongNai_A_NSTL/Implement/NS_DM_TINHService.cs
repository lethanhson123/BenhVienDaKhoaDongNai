namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_TINHService : BaseService<NS_DM_TINH, INS_DM_TINHRepository>
    , INS_DM_TINHService
    {
    private readonly INS_DM_TINHRepository _NS_DM_TINHRepository;
    public NS_DM_TINHService(INS_DM_TINHRepository NS_DM_TINHRepository) : base(NS_DM_TINHRepository)
    {
    _NS_DM_TINHRepository = NS_DM_TINHRepository;
    }
    }
    }

