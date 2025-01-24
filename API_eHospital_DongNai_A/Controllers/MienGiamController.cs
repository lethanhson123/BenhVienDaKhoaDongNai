namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class MienGiamController : BaseController<MienGiam, IMienGiamService>
    {
    private readonly IMienGiamService _MienGiamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public MienGiamController(IMienGiamService MienGiamService, IWebHostEnvironment WebHostEnvironment) : base(MienGiamService, WebHostEnvironment)
    {
    _MienGiamService = MienGiamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

