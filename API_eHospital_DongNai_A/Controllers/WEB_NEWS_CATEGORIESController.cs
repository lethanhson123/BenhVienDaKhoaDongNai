namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class WEB_NEWS_CATEGORIESController : BaseController<WEB_NEWS_CATEGORIES, IWEB_NEWS_CATEGORIESService>
    {
    private readonly IWEB_NEWS_CATEGORIESService _WEB_NEWS_CATEGORIESService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public WEB_NEWS_CATEGORIESController(IWEB_NEWS_CATEGORIESService WEB_NEWS_CATEGORIESService, IWebHostEnvironment WebHostEnvironment) : base(WEB_NEWS_CATEGORIESService, WebHostEnvironment)
    {
    _WEB_NEWS_CATEGORIESService = WEB_NEWS_CATEGORIESService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

