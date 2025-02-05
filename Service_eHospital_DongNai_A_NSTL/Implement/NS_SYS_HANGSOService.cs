namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_SYS_HANGSOService : BaseService<NS_SYS_HANGSO, INS_SYS_HANGSORepository>
    , INS_SYS_HANGSOService
    {
    private readonly INS_SYS_HANGSORepository _NS_SYS_HANGSORepository;
    public NS_SYS_HANGSOService(INS_SYS_HANGSORepository NS_SYS_HANGSORepository) : base(NS_SYS_HANGSORepository)
    {
    _NS_SYS_HANGSORepository = NS_SYS_HANGSORepository;
    }
    }
    }

