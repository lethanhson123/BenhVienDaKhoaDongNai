namespace Service_eHospital_DongNai_A.Implement
{
    public class LichHenService : BaseService<LichHen, ILichHenRepository>
    , ILichHenService
    {
    private readonly ILichHenRepository _LichHenRepository;
    public LichHenService(ILichHenRepository LichHenRepository) : base(LichHenRepository)
    {
    _LichHenRepository = LichHenRepository;
    }
    }
    }

