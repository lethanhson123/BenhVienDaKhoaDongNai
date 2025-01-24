namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_KyThuatService : BaseService<DM_KyThuat, IDM_KyThuatRepository>
    , IDM_KyThuatService
    {
    private readonly IDM_KyThuatRepository _DM_KyThuatRepository;
    public DM_KyThuatService(IDM_KyThuatRepository DM_KyThuatRepository) : base(DM_KyThuatRepository)
    {
    _DM_KyThuatRepository = DM_KyThuatRepository;
    }
    }
    }

