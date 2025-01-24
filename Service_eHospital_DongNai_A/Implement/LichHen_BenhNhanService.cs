namespace Service_eHospital_DongNai_A.Implement
{
    public class LichHen_BenhNhanService : BaseService<LichHen_BenhNhan, ILichHen_BenhNhanRepository>
    , ILichHen_BenhNhanService
    {
    private readonly ILichHen_BenhNhanRepository _LichHen_BenhNhanRepository;
    public LichHen_BenhNhanService(ILichHen_BenhNhanRepository LichHen_BenhNhanRepository) : base(LichHen_BenhNhanRepository)
    {
    _LichHen_BenhNhanRepository = LichHen_BenhNhanRepository;
    }
    }
    }

