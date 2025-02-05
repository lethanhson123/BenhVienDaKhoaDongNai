namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_CHUYENNGANHService : BaseService<NS_DM_CHUYENNGANH, INS_DM_CHUYENNGANHRepository>
    , INS_DM_CHUYENNGANHService
    {
    private readonly INS_DM_CHUYENNGANHRepository _NS_DM_CHUYENNGANHRepository;
    public NS_DM_CHUYENNGANHService(INS_DM_CHUYENNGANHRepository NS_DM_CHUYENNGANHRepository) : base(NS_DM_CHUYENNGANHRepository)
    {
    _NS_DM_CHUYENNGANHRepository = NS_DM_CHUYENNGANHRepository;
    }
    }
    }

