namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_BANGCAPService : BaseService<NS_BANGCAP, INS_BANGCAPRepository>
    , INS_BANGCAPService
    {
    private readonly INS_BANGCAPRepository _NS_BANGCAPRepository;
    public NS_BANGCAPService(INS_BANGCAPRepository NS_BANGCAPRepository) : base(NS_BANGCAPRepository)
    {
    _NS_BANGCAPRepository = NS_BANGCAPRepository;
    }
    }
    }

