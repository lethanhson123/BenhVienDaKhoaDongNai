namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class RIS_MESSAGES_SENDController : BaseController<RIS_MESSAGES_SEND, IRIS_MESSAGES_SENDService>
    {
    private readonly IRIS_MESSAGES_SENDService _RIS_MESSAGES_SENDService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public RIS_MESSAGES_SENDController(IRIS_MESSAGES_SENDService RIS_MESSAGES_SENDService, IWebHostEnvironment WebHostEnvironment) : base(RIS_MESSAGES_SENDService, WebHostEnvironment)
    {
    _RIS_MESSAGES_SENDService = RIS_MESSAGES_SENDService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

