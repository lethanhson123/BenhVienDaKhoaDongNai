namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KeHoachHoiThao_BVThamGiaService : BaseService<CDT_KeHoachHoiThao_BVThamGia, ICDT_KeHoachHoiThao_BVThamGiaRepository>
    , ICDT_KeHoachHoiThao_BVThamGiaService
    {
    private readonly ICDT_KeHoachHoiThao_BVThamGiaRepository _CDT_KeHoachHoiThao_BVThamGiaRepository;
    public CDT_KeHoachHoiThao_BVThamGiaService(ICDT_KeHoachHoiThao_BVThamGiaRepository CDT_KeHoachHoiThao_BVThamGiaRepository) : base(CDT_KeHoachHoiThao_BVThamGiaRepository)
    {
    _CDT_KeHoachHoiThao_BVThamGiaRepository = CDT_KeHoachHoiThao_BVThamGiaRepository;
    }
    }
    }

