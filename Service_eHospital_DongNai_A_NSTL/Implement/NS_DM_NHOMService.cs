namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_NHOMService : BaseService<NS_DM_NHOM, INS_DM_NHOMRepository>
    , INS_DM_NHOMService
    {
    private readonly INS_DM_NHOMRepository _NS_DM_NHOMRepository;
    public NS_DM_NHOMService(INS_DM_NHOMRepository NS_DM_NHOMRepository) : base(NS_DM_NHOMRepository)
    {
    _NS_DM_NHOMRepository = NS_DM_NHOMRepository;
    }
    }
    }

