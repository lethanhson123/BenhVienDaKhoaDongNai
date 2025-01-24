namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_CDT_LoaiService : BaseService<DM_CDT_Loai, IDM_CDT_LoaiRepository>
    , IDM_CDT_LoaiService
    {
    private readonly IDM_CDT_LoaiRepository _DM_CDT_LoaiRepository;
    public DM_CDT_LoaiService(IDM_CDT_LoaiRepository DM_CDT_LoaiRepository) : base(DM_CDT_LoaiRepository)
    {
    _DM_CDT_LoaiRepository = DM_CDT_LoaiRepository;
    }
    }
    }

