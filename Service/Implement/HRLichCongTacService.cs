namespace Service.Implement
{
    public class HRLichCongTacService : BaseService<HRLichCongTac, IHRLichCongTacRepository>
    , IHRLichCongTacService
    {
    private readonly IHRLichCongTacRepository _HRLichCongTacRepository;
    public HRLichCongTacService(IHRLichCongTacRepository HRLichCongTacRepository) : base(HRLichCongTacRepository)
    {
    _HRLichCongTacRepository = HRLichCongTacRepository;
    }
    }
    }

