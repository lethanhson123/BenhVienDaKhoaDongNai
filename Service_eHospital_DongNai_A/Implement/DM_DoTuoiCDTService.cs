namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DoTuoiCDTService : BaseService<DM_DoTuoiCDT, IDM_DoTuoiCDTRepository>
    , IDM_DoTuoiCDTService
    {
    private readonly IDM_DoTuoiCDTRepository _DM_DoTuoiCDTRepository;
    public DM_DoTuoiCDTService(IDM_DoTuoiCDTRepository DM_DoTuoiCDTRepository) : base(DM_DoTuoiCDTRepository)
    {
    _DM_DoTuoiCDTRepository = DM_DoTuoiCDTRepository;
    }
    }
    }

