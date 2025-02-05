namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_NhanVienExcelController : BaseController<DM_NhanVienExcel, IDM_NhanVienExcelService>
    {
    private readonly IDM_NhanVienExcelService _DM_NhanVienExcelService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_NhanVienExcelController(IDM_NhanVienExcelService DM_NhanVienExcelService, IWebHostEnvironment WebHostEnvironment) : base(DM_NhanVienExcelService, WebHostEnvironment)
    {
    _DM_NhanVienExcelService = DM_NhanVienExcelService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

