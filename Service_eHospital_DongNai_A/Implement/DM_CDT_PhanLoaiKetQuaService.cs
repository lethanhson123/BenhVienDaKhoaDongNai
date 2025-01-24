namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_CDT_PhanLoaiKetQuaService : BaseService<DM_CDT_PhanLoaiKetQua, IDM_CDT_PhanLoaiKetQuaRepository>
    , IDM_CDT_PhanLoaiKetQuaService
    {
    private readonly IDM_CDT_PhanLoaiKetQuaRepository _DM_CDT_PhanLoaiKetQuaRepository;
    public DM_CDT_PhanLoaiKetQuaService(IDM_CDT_PhanLoaiKetQuaRepository DM_CDT_PhanLoaiKetQuaRepository) : base(DM_CDT_PhanLoaiKetQuaRepository)
    {
    _DM_CDT_PhanLoaiKetQuaRepository = DM_CDT_PhanLoaiKetQuaRepository;
    }
    }
    }

