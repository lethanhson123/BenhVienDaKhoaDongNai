namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_DSOperatorController : BaseController<NS_RP_DSOperator, INS_RP_DSOperatorService>
    {
    private readonly INS_RP_DSOperatorService _NS_RP_DSOperatorService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_DSOperatorController(INS_RP_DSOperatorService NS_RP_DSOperatorService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_DSOperatorService, WebHostEnvironment)
    {
    _NS_RP_DSOperatorService = NS_RP_DSOperatorService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

