namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_NhomTiemChungService : BaseService<DM_NhomTiemChung, IDM_NhomTiemChungRepository>
    , IDM_NhomTiemChungService
    {
    private readonly IDM_NhomTiemChungRepository _DM_NhomTiemChungRepository;
    public DM_NhomTiemChungService(IDM_NhomTiemChungRepository DM_NhomTiemChungRepository) : base(DM_NhomTiemChungRepository)
    {
    _DM_NhomTiemChungRepository = DM_NhomTiemChungRepository;
    }
    }
    }

