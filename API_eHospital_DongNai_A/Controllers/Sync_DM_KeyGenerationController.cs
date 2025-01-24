namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_DM_KeyGenerationController : BaseController<Sync_DM_KeyGeneration, ISync_DM_KeyGenerationService>
    {
    private readonly ISync_DM_KeyGenerationService _Sync_DM_KeyGenerationService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_DM_KeyGenerationController(ISync_DM_KeyGenerationService Sync_DM_KeyGenerationService, IWebHostEnvironment WebHostEnvironment) : base(Sync_DM_KeyGenerationService, WebHostEnvironment)
    {
    _Sync_DM_KeyGenerationService = Sync_DM_KeyGenerationService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

