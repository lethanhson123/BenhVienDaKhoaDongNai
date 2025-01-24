namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_KhuyenMaiNguoiThanService : BaseService<CSKH_The_KhuyenMaiNguoiThan, ICSKH_The_KhuyenMaiNguoiThanRepository>
    , ICSKH_The_KhuyenMaiNguoiThanService
    {
    private readonly ICSKH_The_KhuyenMaiNguoiThanRepository _CSKH_The_KhuyenMaiNguoiThanRepository;
    public CSKH_The_KhuyenMaiNguoiThanService(ICSKH_The_KhuyenMaiNguoiThanRepository CSKH_The_KhuyenMaiNguoiThanRepository) : base(CSKH_The_KhuyenMaiNguoiThanRepository)
    {
    _CSKH_The_KhuyenMaiNguoiThanRepository = CSKH_The_KhuyenMaiNguoiThanRepository;
    }
    }
    }

