namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DoiTuongService : BaseService<DM_DoiTuong, IDM_DoiTuongRepository>
    , IDM_DoiTuongService
    {
    private readonly IDM_DoiTuongRepository _DM_DoiTuongRepository;
    public DM_DoiTuongService(IDM_DoiTuongRepository DM_DoiTuongRepository) : base(DM_DoiTuongRepository)
    {
    _DM_DoiTuongRepository = DM_DoiTuongRepository;
    }
    }
    }

