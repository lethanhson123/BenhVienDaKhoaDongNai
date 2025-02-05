namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_LSTREPORTController : BaseController<NS_RP_LSTREPORT, INS_RP_LSTREPORTService>
    {
    private readonly INS_RP_LSTREPORTService _NS_RP_LSTREPORTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_LSTREPORTController(INS_RP_LSTREPORTService NS_RP_LSTREPORTService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_LSTREPORTService, WebHostEnvironment)
    {
    _NS_RP_LSTREPORTService = NS_RP_LSTREPORTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

