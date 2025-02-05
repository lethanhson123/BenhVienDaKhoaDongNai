namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_TONGIAOController : BaseController<NS_DM_TONGIAO, INS_DM_TONGIAOService>
    {
    private readonly INS_DM_TONGIAOService _NS_DM_TONGIAOService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_TONGIAOController(INS_DM_TONGIAOService NS_DM_TONGIAOService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_TONGIAOService, WebHostEnvironment)
    {
    _NS_DM_TONGIAOService = NS_DM_TONGIAOService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

