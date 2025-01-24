namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KeHoachHoiThao_CBThamGiaService : BaseService<CDT_KeHoachHoiThao_CBThamGia, ICDT_KeHoachHoiThao_CBThamGiaRepository>
    , ICDT_KeHoachHoiThao_CBThamGiaService
    {
    private readonly ICDT_KeHoachHoiThao_CBThamGiaRepository _CDT_KeHoachHoiThao_CBThamGiaRepository;
    public CDT_KeHoachHoiThao_CBThamGiaService(ICDT_KeHoachHoiThao_CBThamGiaRepository CDT_KeHoachHoiThao_CBThamGiaRepository) : base(CDT_KeHoachHoiThao_CBThamGiaRepository)
    {
    _CDT_KeHoachHoiThao_CBThamGiaRepository = CDT_KeHoachHoiThao_CBThamGiaRepository;
    }
    }
    }

