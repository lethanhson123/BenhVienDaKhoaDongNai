namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LichHenController : BaseController<LichHen, ILichHenService>
    {
    private readonly ILichHenService _LichHenService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LichHenController(ILichHenService LichHenService, IWebHostEnvironment WebHostEnvironment) : base(LichHenService, WebHostEnvironment)
    {
    _LichHenService = LichHenService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

