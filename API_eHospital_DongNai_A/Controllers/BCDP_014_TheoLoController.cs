namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BCDP_014_TheoLoController : BaseController<BCDP_014_TheoLo, IBCDP_014_TheoLoService>
    {
    private readonly IBCDP_014_TheoLoService _BCDP_014_TheoLoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BCDP_014_TheoLoController(IBCDP_014_TheoLoService BCDP_014_TheoLoService, IWebHostEnvironment WebHostEnvironment) : base(BCDP_014_TheoLoService, WebHostEnvironment)
    {
    _BCDP_014_TheoLoService = BCDP_014_TheoLoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

