namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_ThuocTiemChungService : BaseService<DM_ThuocTiemChung, IDM_ThuocTiemChungRepository>
    , IDM_ThuocTiemChungService
    {
    private readonly IDM_ThuocTiemChungRepository _DM_ThuocTiemChungRepository;
    public DM_ThuocTiemChungService(IDM_ThuocTiemChungRepository DM_ThuocTiemChungRepository) : base(DM_ThuocTiemChungRepository)
    {
    _DM_ThuocTiemChungRepository = DM_ThuocTiemChungRepository;
    }
    }
    }

