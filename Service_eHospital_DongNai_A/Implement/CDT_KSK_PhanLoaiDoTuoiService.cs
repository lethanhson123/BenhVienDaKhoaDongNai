namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_PhanLoaiDoTuoiService : BaseService<CDT_KSK_PhanLoaiDoTuoi, ICDT_KSK_PhanLoaiDoTuoiRepository>
    , ICDT_KSK_PhanLoaiDoTuoiService
    {
    private readonly ICDT_KSK_PhanLoaiDoTuoiRepository _CDT_KSK_PhanLoaiDoTuoiRepository;
    public CDT_KSK_PhanLoaiDoTuoiService(ICDT_KSK_PhanLoaiDoTuoiRepository CDT_KSK_PhanLoaiDoTuoiRepository) : base(CDT_KSK_PhanLoaiDoTuoiRepository)
    {
    _CDT_KSK_PhanLoaiDoTuoiRepository = CDT_KSK_PhanLoaiDoTuoiRepository;
    }
    }
    }

