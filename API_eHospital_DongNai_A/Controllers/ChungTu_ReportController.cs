namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTu_ReportController : BaseController<ChungTu_Report, IChungTu_ReportService>
    {
    private readonly IChungTu_ReportService _ChungTu_ReportService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTu_ReportController(IChungTu_ReportService ChungTu_ReportService, IWebHostEnvironment WebHostEnvironment) : base(ChungTu_ReportService, WebHostEnvironment)
    {
    _ChungTu_ReportService = ChungTu_ReportService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

