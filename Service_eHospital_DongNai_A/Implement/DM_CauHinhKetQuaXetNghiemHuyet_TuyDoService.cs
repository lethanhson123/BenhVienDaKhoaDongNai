namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService : BaseService<DM_CauHinhKetQuaXetNghiemHuyet_TuyDo, IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository>
    , IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoService
    {
    private readonly IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository _DM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository;
    public DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService(IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository DM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository) : base(DM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository)
    {
    _DM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository = DM_CauHinhKetQuaXetNghiemHuyet_TuyDoRepository;
    }
    }
    }

