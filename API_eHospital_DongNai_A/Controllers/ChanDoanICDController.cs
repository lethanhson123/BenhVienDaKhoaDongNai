namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChanDoanICDController : BaseController<ChanDoanICD, IChanDoanICDService>
    {
    private readonly IChanDoanICDService _ChanDoanICDService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChanDoanICDController(IChanDoanICDService ChanDoanICDService, IWebHostEnvironment WebHostEnvironment) : base(ChanDoanICDService, WebHostEnvironment)
    {
    _ChanDoanICDService = ChanDoanICDService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

