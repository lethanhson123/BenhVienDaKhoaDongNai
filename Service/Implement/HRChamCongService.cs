namespace Service.Implement
{
    public class HRChamCongService : BaseService<HRChamCong, IHRChamCongRepository>
    , IHRChamCongService
    {
    private readonly IHRChamCongRepository _HRChamCongRepository;
    public HRChamCongService(IHRChamCongRepository HRChamCongRepository) : base(HRChamCongRepository)
    {
    _HRChamCongRepository = HRChamCongRepository;
    }
    }
    }

