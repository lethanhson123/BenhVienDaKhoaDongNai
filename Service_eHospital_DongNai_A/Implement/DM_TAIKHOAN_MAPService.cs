namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_TAIKHOAN_MAPService : BaseService<DM_TAIKHOAN_MAP, IDM_TAIKHOAN_MAPRepository>
    , IDM_TAIKHOAN_MAPService
    {
    private readonly IDM_TAIKHOAN_MAPRepository _DM_TAIKHOAN_MAPRepository;
    public DM_TAIKHOAN_MAPService(IDM_TAIKHOAN_MAPRepository DM_TAIKHOAN_MAPRepository) : base(DM_TAIKHOAN_MAPRepository)
    {
    _DM_TAIKHOAN_MAPRepository = DM_TAIKHOAN_MAPRepository;
    }
    }
    }

