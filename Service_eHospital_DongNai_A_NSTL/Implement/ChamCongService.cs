namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class ChamCongService : BaseService<ChamCong, IChamCongRepository>
    , IChamCongService
    {
    private readonly IChamCongRepository _ChamCongRepository;
    public ChamCongService(IChamCongRepository ChamCongRepository) : base(ChamCongRepository)
    {
    _ChamCongRepository = ChamCongRepository;
    }
    }
    }

