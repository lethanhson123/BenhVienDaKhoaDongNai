namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class cController : BaseController<c, IcService>
    {
    private readonly IcService _cService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public cController(IcService cService, IWebHostEnvironment WebHostEnvironment) : base(cService, WebHostEnvironment)
    {
    _cService = cService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

