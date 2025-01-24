namespace Service_eHospital_DongNai_A.Implement
{
    public class TiepNhanCapCuuService : BaseService<TiepNhanCapCuu, ITiepNhanCapCuuRepository>
    , ITiepNhanCapCuuService
    {
    private readonly ITiepNhanCapCuuRepository _TiepNhanCapCuuRepository;
    public TiepNhanCapCuuService(ITiepNhanCapCuuRepository TiepNhanCapCuuRepository) : base(TiepNhanCapCuuRepository)
    {
    _TiepNhanCapCuuRepository = TiepNhanCapCuuRepository;
    }
    }
    }

