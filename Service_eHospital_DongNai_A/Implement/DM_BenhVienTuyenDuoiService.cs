namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_BenhVienTuyenDuoiService : BaseService<DM_BenhVienTuyenDuoi, IDM_BenhVienTuyenDuoiRepository>
    , IDM_BenhVienTuyenDuoiService
    {
    private readonly IDM_BenhVienTuyenDuoiRepository _DM_BenhVienTuyenDuoiRepository;
    public DM_BenhVienTuyenDuoiService(IDM_BenhVienTuyenDuoiRepository DM_BenhVienTuyenDuoiRepository) : base(DM_BenhVienTuyenDuoiRepository)
    {
    _DM_BenhVienTuyenDuoiRepository = DM_BenhVienTuyenDuoiRepository;
    }
    }
    }

