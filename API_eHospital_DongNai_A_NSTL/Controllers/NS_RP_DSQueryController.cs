namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_DSQueryController : BaseController<NS_RP_DSQuery, INS_RP_DSQueryService>
    {
    private readonly INS_RP_DSQueryService _NS_RP_DSQueryService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_DSQueryController(INS_RP_DSQueryService NS_RP_DSQueryService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_DSQueryService, WebHostEnvironment)
    {
    _NS_RP_DSQueryService = NS_RP_DSQueryService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

