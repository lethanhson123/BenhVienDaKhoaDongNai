namespace Service_eHospital_DongNai_A.Implement
{
    public class TiepNhan_BHYT_CuService : BaseService<TiepNhan_BHYT_Cu, ITiepNhan_BHYT_CuRepository>
    , ITiepNhan_BHYT_CuService
    {
    private readonly ITiepNhan_BHYT_CuRepository _TiepNhan_BHYT_CuRepository;
    public TiepNhan_BHYT_CuService(ITiepNhan_BHYT_CuRepository TiepNhan_BHYT_CuRepository) : base(TiepNhan_BHYT_CuRepository)
    {
    _TiepNhan_BHYT_CuRepository = TiepNhan_BHYT_CuRepository;
    }
    }
    }

