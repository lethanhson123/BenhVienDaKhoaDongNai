namespace Service_eHospital_DongNai_A.Implement
{
    public class CSKH_The_ChuyenDoiLoaiThanhVienService : BaseService<CSKH_The_ChuyenDoiLoaiThanhVien, ICSKH_The_ChuyenDoiLoaiThanhVienRepository>
    , ICSKH_The_ChuyenDoiLoaiThanhVienService
    {
    private readonly ICSKH_The_ChuyenDoiLoaiThanhVienRepository _CSKH_The_ChuyenDoiLoaiThanhVienRepository;
    public CSKH_The_ChuyenDoiLoaiThanhVienService(ICSKH_The_ChuyenDoiLoaiThanhVienRepository CSKH_The_ChuyenDoiLoaiThanhVienRepository) : base(CSKH_The_ChuyenDoiLoaiThanhVienRepository)
    {
    _CSKH_The_ChuyenDoiLoaiThanhVienRepository = CSKH_The_ChuyenDoiLoaiThanhVienRepository;
    }
    }
    }

