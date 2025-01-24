namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DoiTuongCDTService : BaseService<DM_DoiTuongCDT, IDM_DoiTuongCDTRepository>
    , IDM_DoiTuongCDTService
    {
    private readonly IDM_DoiTuongCDTRepository _DM_DoiTuongCDTRepository;
    public DM_DoiTuongCDTService(IDM_DoiTuongCDTRepository DM_DoiTuongCDTRepository) : base(DM_DoiTuongCDTRepository)
    {
    _DM_DoiTuongCDTRepository = DM_DoiTuongCDTRepository;
    }
    }
    }

