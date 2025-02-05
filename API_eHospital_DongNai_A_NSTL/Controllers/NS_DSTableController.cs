namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DSTableController : BaseController<NS_DSTable, INS_DSTableService>
    {
    private readonly INS_DSTableService _NS_DSTableService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DSTableController(INS_DSTableService NS_DSTableService, IWebHostEnvironment WebHostEnvironment) : base(NS_DSTableService, WebHostEnvironment)
    {
    _NS_DSTableService = NS_DSTableService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

