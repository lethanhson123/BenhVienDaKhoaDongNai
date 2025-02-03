namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class testController : BaseController<test, ItestService>
    {
    private readonly ItestService _testService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public testController(ItestService testService, IWebHostEnvironment WebHostEnvironment) : base(testService, WebHostEnvironment)
    {
    _testService = testService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

