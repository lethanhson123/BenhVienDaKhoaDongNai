namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_DSTableController : BaseController<NS_RP_DSTable, INS_RP_DSTableService>
    {
    private readonly INS_RP_DSTableService _NS_RP_DSTableService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_DSTableController(INS_RP_DSTableService NS_RP_DSTableService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_DSTableService, WebHostEnvironment)
    {
    _NS_RP_DSTableService = NS_RP_DSTableService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

