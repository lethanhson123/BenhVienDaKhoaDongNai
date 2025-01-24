namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_CongtyController : BaseController<KSK_Congty, IKSK_CongtyService>
    {
    private readonly IKSK_CongtyService _KSK_CongtyService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_CongtyController(IKSK_CongtyService KSK_CongtyService, IWebHostEnvironment WebHostEnvironment) : base(KSK_CongtyService, WebHostEnvironment)
    {
    _KSK_CongtyService = KSK_CongtyService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

