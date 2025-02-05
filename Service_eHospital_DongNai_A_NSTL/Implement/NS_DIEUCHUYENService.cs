namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DIEUCHUYENService : BaseService<NS_DIEUCHUYEN, INS_DIEUCHUYENRepository>
    , INS_DIEUCHUYENService
    {
    private readonly INS_DIEUCHUYENRepository _NS_DIEUCHUYENRepository;
    public NS_DIEUCHUYENService(INS_DIEUCHUYENRepository NS_DIEUCHUYENRepository) : base(NS_DIEUCHUYENRepository)
    {
    _NS_DIEUCHUYENRepository = NS_DIEUCHUYENRepository;
    }
    }
    }

