namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LichHen_HisController : BaseController<LichHen_His, ILichHen_HisService>
    {
    private readonly ILichHen_HisService _LichHen_HisService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LichHen_HisController(ILichHen_HisService LichHen_HisService, IWebHostEnvironment WebHostEnvironment) : base(LichHen_HisService, WebHostEnvironment)
    {
    _LichHen_HisService = LichHen_HisService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

