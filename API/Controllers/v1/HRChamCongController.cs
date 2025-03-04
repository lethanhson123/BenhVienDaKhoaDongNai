namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRChamCongController : BaseController<HRChamCong, IHRChamCongService>
    {
    private readonly IHRChamCongService _HRChamCongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRChamCongController(IHRChamCongService HRChamCongService, IWebHostEnvironment WebHostEnvironment) : base(HRChamCongService, WebHostEnvironment)
    {
    _HRChamCongService = HRChamCongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

