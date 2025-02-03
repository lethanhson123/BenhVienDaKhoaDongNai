namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhSuDefinitionsController : BaseController<BenhSuDefinitions, IBenhSuDefinitionsService>
    {
    private readonly IBenhSuDefinitionsService _BenhSuDefinitionsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhSuDefinitionsController(IBenhSuDefinitionsService BenhSuDefinitionsService, IWebHostEnvironment WebHostEnvironment) : base(BenhSuDefinitionsService, WebHostEnvironment)
    {
    _BenhSuDefinitionsService = BenhSuDefinitionsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

