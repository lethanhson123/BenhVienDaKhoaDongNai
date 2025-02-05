namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class DM_NgachBac_ExcelService : BaseService<DM_NgachBac_Excel, IDM_NgachBac_ExcelRepository>
    , IDM_NgachBac_ExcelService
    {
    private readonly IDM_NgachBac_ExcelRepository _DM_NgachBac_ExcelRepository;
    public DM_NgachBac_ExcelService(IDM_NgachBac_ExcelRepository DM_NgachBac_ExcelRepository) : base(DM_NgachBac_ExcelRepository)
    {
    _DM_NgachBac_ExcelRepository = DM_NgachBac_ExcelRepository;
    }
    }
    }

