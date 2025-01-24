namespace Service_eHospital_DongNai_A.Implement
{
    public class KiemDiemTuVongService : BaseService<KiemDiemTuVong, IKiemDiemTuVongRepository>
    , IKiemDiemTuVongService
    {
    private readonly IKiemDiemTuVongRepository _KiemDiemTuVongRepository;
    public KiemDiemTuVongService(IKiemDiemTuVongRepository KiemDiemTuVongRepository) : base(KiemDiemTuVongRepository)
    {
    _KiemDiemTuVongRepository = KiemDiemTuVongRepository;
    }
    }
    }

