namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_DanhSachDoiTuongKMService : BaseService<CSKH_The_DanhSachDoiTuongKM, ICSKH_The_DanhSachDoiTuongKMRepository>
    , ICSKH_The_DanhSachDoiTuongKMService
    {
    private readonly ICSKH_The_DanhSachDoiTuongKMRepository _CSKH_The_DanhSachDoiTuongKMRepository;
    public CSKH_The_DanhSachDoiTuongKMService(ICSKH_The_DanhSachDoiTuongKMRepository CSKH_The_DanhSachDoiTuongKMRepository) : base(CSKH_The_DanhSachDoiTuongKMRepository)
    {
    _CSKH_The_DanhSachDoiTuongKMRepository = CSKH_The_DanhSachDoiTuongKMRepository;
    }
    }
    }

