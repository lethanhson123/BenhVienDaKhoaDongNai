namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_GIAHANHOPDONGController : BaseController<NS_GIAHANHOPDONG, INS_GIAHANHOPDONGService>
    {
    private readonly INS_GIAHANHOPDONGService _NS_GIAHANHOPDONGService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_GIAHANHOPDONGController(INS_GIAHANHOPDONGService NS_GIAHANHOPDONGService, IWebHostEnvironment WebHostEnvironment) : base(NS_GIAHANHOPDONGService, WebHostEnvironment)
    {
    _NS_GIAHANHOPDONGService = NS_GIAHANHOPDONGService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

