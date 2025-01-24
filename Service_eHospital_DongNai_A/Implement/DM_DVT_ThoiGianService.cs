namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DVT_ThoiGianService : BaseService<DM_DVT_ThoiGian, IDM_DVT_ThoiGianRepository>
    , IDM_DVT_ThoiGianService
    {
    private readonly IDM_DVT_ThoiGianRepository _DM_DVT_ThoiGianRepository;
    public DM_DVT_ThoiGianService(IDM_DVT_ThoiGianRepository DM_DVT_ThoiGianRepository) : base(DM_DVT_ThoiGianRepository)
    {
    _DM_DVT_ThoiGianRepository = DM_DVT_ThoiGianRepository;
    }
    }
    }

