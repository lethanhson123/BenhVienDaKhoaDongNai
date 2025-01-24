namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class traceController : BaseController<trace, ItraceService>
    {
    private readonly ItraceService _traceService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public traceController(ItraceService traceService, IWebHostEnvironment WebHostEnvironment) : base(traceService, WebHostEnvironment)
    {
    _traceService = traceService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

