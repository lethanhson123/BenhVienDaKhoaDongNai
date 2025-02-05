namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LYDONGHIPHEPService : BaseService<NS_DM_LYDONGHIPHEP, INS_DM_LYDONGHIPHEPRepository>
    , INS_DM_LYDONGHIPHEPService
    {
    private readonly INS_DM_LYDONGHIPHEPRepository _NS_DM_LYDONGHIPHEPRepository;
    public NS_DM_LYDONGHIPHEPService(INS_DM_LYDONGHIPHEPRepository NS_DM_LYDONGHIPHEPRepository) : base(NS_DM_LYDONGHIPHEPRepository)
    {
    _NS_DM_LYDONGHIPHEPRepository = NS_DM_LYDONGHIPHEPRepository;
    }
    }
    }

