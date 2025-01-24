namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_VTYTController : BaseController<KhamBenh_VTYT, IKhamBenh_VTYTService>
    {
    private readonly IKhamBenh_VTYTService _KhamBenh_VTYTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamBenh_VTYTController(IKhamBenh_VTYTService KhamBenh_VTYTService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_VTYTService, WebHostEnvironment)
    {
    _KhamBenh_VTYTService = KhamBenh_VTYTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

