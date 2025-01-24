namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TinSMSController : BaseController<TinSMS, ITinSMSService>
    {
    private readonly ITinSMSService _TinSMSService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TinSMSController(ITinSMSService TinSMSService, IWebHostEnvironment WebHostEnvironment) : base(TinSMSService, WebHostEnvironment)
    {
    _TinSMSService = TinSMSService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

