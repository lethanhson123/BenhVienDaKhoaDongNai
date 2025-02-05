namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class sysdiagramsService : BaseService<sysdiagrams, IsysdiagramsRepository>
    , IsysdiagramsService
    {
    private readonly IsysdiagramsRepository _sysdiagramsRepository;
    public sysdiagramsService(IsysdiagramsRepository sysdiagramsRepository) : base(sysdiagramsRepository)
    {
    _sysdiagramsRepository = sysdiagramsRepository;
    }
    }
    }

