namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRLichCongTacController : BaseController<HRLichCongTac, IHRLichCongTacService>
    {
    private readonly IHRLichCongTacService _HRLichCongTacService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRLichCongTacController(IHRLichCongTacService HRLichCongTacService, IWebHostEnvironment WebHostEnvironment) : base(HRLichCongTacService, WebHostEnvironment)
    {
    _HRLichCongTacService = HRLichCongTacService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

