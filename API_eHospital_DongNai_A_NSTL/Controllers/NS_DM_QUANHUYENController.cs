namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_QUANHUYENController : BaseController<NS_DM_QUANHUYEN, INS_DM_QUANHUYENService>
    {
    private readonly INS_DM_QUANHUYENService _NS_DM_QUANHUYENService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_QUANHUYENController(INS_DM_QUANHUYENService NS_DM_QUANHUYENService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_QUANHUYENService, WebHostEnvironment)
    {
    _NS_DM_QUANHUYENService = NS_DM_QUANHUYENService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

