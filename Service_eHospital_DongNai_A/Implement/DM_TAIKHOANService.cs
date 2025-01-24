namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_TAIKHOANService : BaseService<DM_TAIKHOAN, IDM_TAIKHOANRepository>
    , IDM_TAIKHOANService
    {
    private readonly IDM_TAIKHOANRepository _DM_TAIKHOANRepository;
    public DM_TAIKHOANService(IDM_TAIKHOANRepository DM_TAIKHOANRepository) : base(DM_TAIKHOANRepository)
    {
    _DM_TAIKHOANRepository = DM_TAIKHOANRepository;
    }
    }
    }

