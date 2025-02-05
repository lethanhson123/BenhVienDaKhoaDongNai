namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_LSTSUBREPORTController : BaseController<NS_RP_LSTSUBREPORT, INS_RP_LSTSUBREPORTService>
    {
    private readonly INS_RP_LSTSUBREPORTService _NS_RP_LSTSUBREPORTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_LSTSUBREPORTController(INS_RP_LSTSUBREPORTService NS_RP_LSTSUBREPORTService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_LSTSUBREPORTService, WebHostEnvironment)
    {
    _NS_RP_LSTSUBREPORTService = NS_RP_LSTSUBREPORTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

