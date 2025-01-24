namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_DM_LoaiKhachHangService : BaseService<CSKH_DM_LoaiKhachHang, ICSKH_DM_LoaiKhachHangRepository>
    , ICSKH_DM_LoaiKhachHangService
    {
    private readonly ICSKH_DM_LoaiKhachHangRepository _CSKH_DM_LoaiKhachHangRepository;
    public CSKH_DM_LoaiKhachHangService(ICSKH_DM_LoaiKhachHangRepository CSKH_DM_LoaiKhachHangRepository) : base(CSKH_DM_LoaiKhachHangRepository)
    {
    _CSKH_DM_LoaiKhachHangRepository = CSKH_DM_LoaiKhachHangRepository;
    }
    }
    }

