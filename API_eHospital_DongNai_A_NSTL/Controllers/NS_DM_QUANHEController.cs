namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_QUANHEController : BaseController<NS_DM_QUANHE, INS_DM_QUANHEService>
    {
    private readonly INS_DM_QUANHEService _NS_DM_QUANHEService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_QUANHEController(INS_DM_QUANHEService NS_DM_QUANHEService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_QUANHEService, WebHostEnvironment)
    {
    _NS_DM_QUANHEService = NS_DM_QUANHEService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

