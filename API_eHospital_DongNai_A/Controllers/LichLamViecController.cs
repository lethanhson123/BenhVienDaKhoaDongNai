namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LichLamViecController : BaseController<LichLamViec, ILichLamViecService>
    {
    private readonly ILichLamViecService _LichLamViecService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LichLamViecController(ILichLamViecService LichLamViecService, IWebHostEnvironment WebHostEnvironment) : base(LichLamViecService, WebHostEnvironment)
    {
    _LichLamViecService = LichLamViecService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

