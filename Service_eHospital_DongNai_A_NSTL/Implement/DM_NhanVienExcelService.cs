namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class DM_NhanVienExcelService : BaseService<DM_NhanVienExcel, IDM_NhanVienExcelRepository>
    , IDM_NhanVienExcelService
    {
    private readonly IDM_NhanVienExcelRepository _DM_NhanVienExcelRepository;
    public DM_NhanVienExcelService(IDM_NhanVienExcelRepository DM_NhanVienExcelRepository) : base(DM_NhanVienExcelRepository)
    {
    _DM_NhanVienExcelRepository = DM_NhanVienExcelRepository;
    }
    }
    }

