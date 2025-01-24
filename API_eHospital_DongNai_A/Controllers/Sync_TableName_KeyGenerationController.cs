namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_TableName_KeyGenerationController : BaseController<Sync_TableName_KeyGeneration, ISync_TableName_KeyGenerationService>
    {
    private readonly ISync_TableName_KeyGenerationService _Sync_TableName_KeyGenerationService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_TableName_KeyGenerationController(ISync_TableName_KeyGenerationService Sync_TableName_KeyGenerationService, IWebHostEnvironment WebHostEnvironment) : base(Sync_TableName_KeyGenerationService, WebHostEnvironment)
    {
    _Sync_TableName_KeyGenerationService = Sync_TableName_KeyGenerationService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

