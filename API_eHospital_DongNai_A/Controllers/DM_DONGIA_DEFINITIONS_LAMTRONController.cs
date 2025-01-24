namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DONGIA_DEFINITIONS_LAMTRONController : BaseController<DM_DONGIA_DEFINITIONS_LAMTRON, IDM_DONGIA_DEFINITIONS_LAMTRONService>
    {
    private readonly IDM_DONGIA_DEFINITIONS_LAMTRONService _DM_DONGIA_DEFINITIONS_LAMTRONService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DONGIA_DEFINITIONS_LAMTRONController(IDM_DONGIA_DEFINITIONS_LAMTRONService DM_DONGIA_DEFINITIONS_LAMTRONService, IWebHostEnvironment WebHostEnvironment) : base(DM_DONGIA_DEFINITIONS_LAMTRONService, WebHostEnvironment)
    {
    _DM_DONGIA_DEFINITIONS_LAMTRONService = DM_DONGIA_DEFINITIONS_LAMTRONService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

