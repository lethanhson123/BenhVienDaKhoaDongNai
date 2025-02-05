namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_CHAMCONGController : BaseController<NS_CHAMCONG, INS_CHAMCONGService>
    {
    private readonly INS_CHAMCONGService _NS_CHAMCONGService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_CHAMCONGController(INS_CHAMCONGService NS_CHAMCONGService, IWebHostEnvironment WebHostEnvironment) : base(NS_CHAMCONGService, WebHostEnvironment)
    {
    _NS_CHAMCONGService = NS_CHAMCONGService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

