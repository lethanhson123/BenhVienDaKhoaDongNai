namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_DieuTriTuyenDuoiService : BaseService<CDT_DieuTriTuyenDuoi, ICDT_DieuTriTuyenDuoiRepository>
    , ICDT_DieuTriTuyenDuoiService
    {
    private readonly ICDT_DieuTriTuyenDuoiRepository _CDT_DieuTriTuyenDuoiRepository;
    public CDT_DieuTriTuyenDuoiService(ICDT_DieuTriTuyenDuoiRepository CDT_DieuTriTuyenDuoiRepository) : base(CDT_DieuTriTuyenDuoiRepository)
    {
    _CDT_DieuTriTuyenDuoiRepository = CDT_DieuTriTuyenDuoiRepository;
    }
    }
    }

