namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuChiTiet_ReportController : BaseController<ChungTuChiTiet_Report, IChungTuChiTiet_ReportService>
    {
    private readonly IChungTuChiTiet_ReportService _ChungTuChiTiet_ReportService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTuChiTiet_ReportController(IChungTuChiTiet_ReportService ChungTuChiTiet_ReportService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuChiTiet_ReportService, WebHostEnvironment)
    {
    _ChungTuChiTiet_ReportService = ChungTuChiTiet_ReportService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

