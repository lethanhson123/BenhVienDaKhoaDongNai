namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class WEB_NEWSController : BaseController<WEB_NEWS, IWEB_NEWSService>
    {
    private readonly IWEB_NEWSService _WEB_NEWSService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public WEB_NEWSController(IWEB_NEWSService WEB_NEWSService, IWebHostEnvironment WebHostEnvironment) : base(WEB_NEWSService, WebHostEnvironment)
    {
    _WEB_NEWSService = WEB_NEWSService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

