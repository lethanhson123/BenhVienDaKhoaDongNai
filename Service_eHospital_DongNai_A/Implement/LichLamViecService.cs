namespace Service_eHospital_DongNai_A.Implement
{
    public class LichLamViecService : BaseService<LichLamViec, ILichLamViecRepository>
    , ILichLamViecService
    {
    private readonly ILichLamViecRepository _LichLamViecRepository;
    public LichLamViecService(ILichLamViecRepository LichLamViecRepository) : base(LichLamViecRepository)
    {
    _LichLamViecRepository = LichLamViecRepository;
    }
    }
    }

