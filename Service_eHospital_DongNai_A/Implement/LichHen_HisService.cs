namespace Service_eHospital_DongNai_A.Implement
{
    public class LichHen_HisService : BaseService<LichHen_His, ILichHen_HisRepository>
    , ILichHen_HisService
    {
    private readonly ILichHen_HisRepository _LichHen_HisRepository;
    public LichHen_HisService(ILichHen_HisRepository LichHen_HisRepository) : base(LichHen_HisRepository)
    {
    _LichHen_HisRepository = LichHen_HisRepository;
    }
    }
    }

