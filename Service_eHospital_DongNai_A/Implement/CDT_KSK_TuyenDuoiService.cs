namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_TuyenDuoiService : BaseService<CDT_KSK_TuyenDuoi, ICDT_KSK_TuyenDuoiRepository>
    , ICDT_KSK_TuyenDuoiService
    {
    private readonly ICDT_KSK_TuyenDuoiRepository _CDT_KSK_TuyenDuoiRepository;
    public CDT_KSK_TuyenDuoiService(ICDT_KSK_TuyenDuoiRepository CDT_KSK_TuyenDuoiRepository) : base(CDT_KSK_TuyenDuoiRepository)
    {
    _CDT_KSK_TuyenDuoiRepository = CDT_KSK_TuyenDuoiRepository;
    }
    }
    }

