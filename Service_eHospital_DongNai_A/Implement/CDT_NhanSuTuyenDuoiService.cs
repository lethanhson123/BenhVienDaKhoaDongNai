namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_NhanSuTuyenDuoiService : BaseService<CDT_NhanSuTuyenDuoi, ICDT_NhanSuTuyenDuoiRepository>
    , ICDT_NhanSuTuyenDuoiService
    {
    private readonly ICDT_NhanSuTuyenDuoiRepository _CDT_NhanSuTuyenDuoiRepository;
    public CDT_NhanSuTuyenDuoiService(ICDT_NhanSuTuyenDuoiRepository CDT_NhanSuTuyenDuoiRepository) : base(CDT_NhanSuTuyenDuoiRepository)
    {
    _CDT_NhanSuTuyenDuoiRepository = CDT_NhanSuTuyenDuoiRepository;
    }
    }
    }

