namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_TINHController : BaseController<NS_DM_TINH, INS_DM_TINHService>
    {
    private readonly INS_DM_TINHService _NS_DM_TINHService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_TINHController(INS_DM_TINHService NS_DM_TINHService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_TINHService, WebHostEnvironment)
    {
    _NS_DM_TINHService = NS_DM_TINHService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

