namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhSuController : BaseController<BenhSu, IBenhSuService>
    {
    private readonly IBenhSuService _BenhSuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhSuController(IBenhSuService BenhSuService, IWebHostEnvironment WebHostEnvironment) : base(BenhSuService, WebHostEnvironment)
    {
    _BenhSuService = BenhSuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

