namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BHYT_KiemTraController : BaseController<BHYT_KiemTra, IBHYT_KiemTraService>
    {
    private readonly IBHYT_KiemTraService _BHYT_KiemTraService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BHYT_KiemTraController(IBHYT_KiemTraService BHYT_KiemTraService, IWebHostEnvironment WebHostEnvironment) : base(BHYT_KiemTraService, WebHostEnvironment)
    {
    _BHYT_KiemTraService = BHYT_KiemTraService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

