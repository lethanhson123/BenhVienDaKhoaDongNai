namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KyThuatTuyenDuoiService : BaseService<CDT_KyThuatTuyenDuoi, ICDT_KyThuatTuyenDuoiRepository>
    , ICDT_KyThuatTuyenDuoiService
    {
    private readonly ICDT_KyThuatTuyenDuoiRepository _CDT_KyThuatTuyenDuoiRepository;
    public CDT_KyThuatTuyenDuoiService(ICDT_KyThuatTuyenDuoiRepository CDT_KyThuatTuyenDuoiRepository) : base(CDT_KyThuatTuyenDuoiRepository)
    {
    _CDT_KyThuatTuyenDuoiRepository = CDT_KyThuatTuyenDuoiRepository;
    }
    }
    }

