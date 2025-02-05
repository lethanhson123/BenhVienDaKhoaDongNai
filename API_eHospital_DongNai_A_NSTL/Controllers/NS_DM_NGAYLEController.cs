namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_NGAYLEController : BaseController<NS_DM_NGAYLE, INS_DM_NGAYLEService>
    {
    private readonly INS_DM_NGAYLEService _NS_DM_NGAYLEService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_NGAYLEController(INS_DM_NGAYLEService NS_DM_NGAYLEService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_NGAYLEService, WebHostEnvironment)
    {
    _NS_DM_NGAYLEService = NS_DM_NGAYLEService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

