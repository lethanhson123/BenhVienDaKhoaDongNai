namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_HopDongController : BaseController<KSK_HopDong, IKSK_HopDongService>
    {
    private readonly IKSK_HopDongService _KSK_HopDongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_HopDongController(IKSK_HopDongService KSK_HopDongService, IWebHostEnvironment WebHostEnvironment) : base(KSK_HopDongService, WebHostEnvironment)
    {
    _KSK_HopDongService = KSK_HopDongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

