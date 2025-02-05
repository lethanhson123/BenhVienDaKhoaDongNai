namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_PhuCapController : BaseController<NS_DM_PhuCap, INS_DM_PhuCapService>
    {
    private readonly INS_DM_PhuCapService _NS_DM_PhuCapService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_PhuCapController(INS_DM_PhuCapService NS_DM_PhuCapService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_PhuCapService, WebHostEnvironment)
    {
    _NS_DM_PhuCapService = NS_DM_PhuCapService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

