namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_TUYENDUNGController : BaseController<NS_TUYENDUNG, INS_TUYENDUNGService>
    {
    private readonly INS_TUYENDUNGService _NS_TUYENDUNGService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_TUYENDUNGController(INS_TUYENDUNGService NS_TUYENDUNGService, IWebHostEnvironment WebHostEnvironment) : base(NS_TUYENDUNGService, WebHostEnvironment)
    {
    _NS_TUYENDUNGService = NS_TUYENDUNGService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

