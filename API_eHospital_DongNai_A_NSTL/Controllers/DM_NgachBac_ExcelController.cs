namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_NgachBac_ExcelController : BaseController<DM_NgachBac_Excel, IDM_NgachBac_ExcelService>
    {
    private readonly IDM_NgachBac_ExcelService _DM_NgachBac_ExcelService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_NgachBac_ExcelController(IDM_NgachBac_ExcelService DM_NgachBac_ExcelService, IWebHostEnvironment WebHostEnvironment) : base(DM_NgachBac_ExcelService, WebHostEnvironment)
    {
    _DM_NgachBac_ExcelService = DM_NgachBac_ExcelService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

