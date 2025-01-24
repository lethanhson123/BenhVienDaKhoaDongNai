namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_TrangThietBiTuyenDuoiService : BaseService<CDT_TrangThietBiTuyenDuoi, ICDT_TrangThietBiTuyenDuoiRepository>
    , ICDT_TrangThietBiTuyenDuoiService
    {
    private readonly ICDT_TrangThietBiTuyenDuoiRepository _CDT_TrangThietBiTuyenDuoiRepository;
    public CDT_TrangThietBiTuyenDuoiService(ICDT_TrangThietBiTuyenDuoiRepository CDT_TrangThietBiTuyenDuoiRepository) : base(CDT_TrangThietBiTuyenDuoiRepository)
    {
    _CDT_TrangThietBiTuyenDuoiRepository = CDT_TrangThietBiTuyenDuoiRepository;
    }
    }
    }

