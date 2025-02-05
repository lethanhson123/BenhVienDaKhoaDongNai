namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_L_CHAMCONGVANGController : BaseController<NS_L_CHAMCONGVANG, INS_L_CHAMCONGVANGService>
    {
    private readonly INS_L_CHAMCONGVANGService _NS_L_CHAMCONGVANGService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_L_CHAMCONGVANGController(INS_L_CHAMCONGVANGService NS_L_CHAMCONGVANGService, IWebHostEnvironment WebHostEnvironment) : base(NS_L_CHAMCONGVANGService, WebHostEnvironment)
    {
    _NS_L_CHAMCONGVANGService = NS_L_CHAMCONGVANGService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

