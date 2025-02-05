namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_CHUYENNGANHController : BaseController<NS_DM_CHUYENNGANH, INS_DM_CHUYENNGANHService>
    {
    private readonly INS_DM_CHUYENNGANHService _NS_DM_CHUYENNGANHService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_CHUYENNGANHController(INS_DM_CHUYENNGANHService NS_DM_CHUYENNGANHService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_CHUYENNGANHService, WebHostEnvironment)
    {
    _NS_DM_CHUYENNGANHService = NS_DM_CHUYENNGANHService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

