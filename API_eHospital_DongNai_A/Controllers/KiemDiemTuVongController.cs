namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KiemDiemTuVongController : BaseController<KiemDiemTuVong, IKiemDiemTuVongService>
    {
    private readonly IKiemDiemTuVongService _KiemDiemTuVongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KiemDiemTuVongController(IKiemDiemTuVongService KiemDiemTuVongService, IWebHostEnvironment WebHostEnvironment) : base(KiemDiemTuVongService, WebHostEnvironment)
    {
    _KiemDiemTuVongService = KiemDiemTuVongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

