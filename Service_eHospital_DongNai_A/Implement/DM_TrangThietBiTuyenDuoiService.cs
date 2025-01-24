namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_TrangThietBiTuyenDuoiService : BaseService<DM_TrangThietBiTuyenDuoi, IDM_TrangThietBiTuyenDuoiRepository>
    , IDM_TrangThietBiTuyenDuoiService
    {
    private readonly IDM_TrangThietBiTuyenDuoiRepository _DM_TrangThietBiTuyenDuoiRepository;
    public DM_TrangThietBiTuyenDuoiService(IDM_TrangThietBiTuyenDuoiRepository DM_TrangThietBiTuyenDuoiRepository) : base(DM_TrangThietBiTuyenDuoiRepository)
    {
    _DM_TrangThietBiTuyenDuoiRepository = DM_TrangThietBiTuyenDuoiRepository;
    }
    }
    }

