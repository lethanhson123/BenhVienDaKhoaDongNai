namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_PhanLoaiDoiTuongService : BaseService<CDT_KSK_PhanLoaiDoiTuong, ICDT_KSK_PhanLoaiDoiTuongRepository>
    , ICDT_KSK_PhanLoaiDoiTuongService
    {
    private readonly ICDT_KSK_PhanLoaiDoiTuongRepository _CDT_KSK_PhanLoaiDoiTuongRepository;
    public CDT_KSK_PhanLoaiDoiTuongService(ICDT_KSK_PhanLoaiDoiTuongRepository CDT_KSK_PhanLoaiDoiTuongRepository) : base(CDT_KSK_PhanLoaiDoiTuongRepository)
    {
    _CDT_KSK_PhanLoaiDoiTuongRepository = CDT_KSK_PhanLoaiDoiTuongRepository;
    }
    }
    }

