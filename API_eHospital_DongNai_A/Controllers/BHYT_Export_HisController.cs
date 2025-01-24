namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BHYT_Export_HisController : BaseController<BHYT_Export_His, IBHYT_Export_HisService>
    {
    private readonly IBHYT_Export_HisService _BHYT_Export_HisService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BHYT_Export_HisController(IBHYT_Export_HisService BHYT_Export_HisService, IWebHostEnvironment WebHostEnvironment) : base(BHYT_Export_HisService, WebHostEnvironment)
    {
    _BHYT_Export_HisService = BHYT_Export_HisService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

