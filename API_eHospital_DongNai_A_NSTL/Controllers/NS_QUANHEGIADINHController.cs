namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_QUANHEGIADINHController : BaseController<NS_QUANHEGIADINH, INS_QUANHEGIADINHService>
    {
    private readonly INS_QUANHEGIADINHService _NS_QUANHEGIADINHService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_QUANHEGIADINHController(INS_QUANHEGIADINHService NS_QUANHEGIADINHService, IWebHostEnvironment WebHostEnvironment) : base(NS_QUANHEGIADINHService, WebHostEnvironment)
    {
    _NS_QUANHEGIADINHService = NS_QUANHEGIADINHService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

