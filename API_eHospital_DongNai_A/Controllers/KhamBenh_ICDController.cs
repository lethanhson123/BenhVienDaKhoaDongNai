namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_ICDController : BaseController<KhamBenh_ICD, IKhamBenh_ICDService>
    {
    private readonly IKhamBenh_ICDService _KhamBenh_ICDService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamBenh_ICDController(IKhamBenh_ICDService KhamBenh_ICDService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_ICDService, WebHostEnvironment)
    {
    _KhamBenh_ICDService = KhamBenh_ICDService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

