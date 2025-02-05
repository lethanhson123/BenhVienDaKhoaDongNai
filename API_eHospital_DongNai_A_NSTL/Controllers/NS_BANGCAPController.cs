namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_BANGCAPController : BaseController<NS_BANGCAP, INS_BANGCAPService>
    {
    private readonly INS_BANGCAPService _NS_BANGCAPService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_BANGCAPController(INS_BANGCAPService NS_BANGCAPService, IWebHostEnvironment WebHostEnvironment) : base(NS_BANGCAPService, WebHostEnvironment)
    {
    _NS_BANGCAPService = NS_BANGCAPService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

