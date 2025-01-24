namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ObjectsMappingController : BaseController<ObjectsMapping, IObjectsMappingService>
    {
    private readonly IObjectsMappingService _ObjectsMappingService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ObjectsMappingController(IObjectsMappingService ObjectsMappingService, IWebHostEnvironment WebHostEnvironment) : base(ObjectsMappingService, WebHostEnvironment)
    {
    _ObjectsMappingService = ObjectsMappingService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

