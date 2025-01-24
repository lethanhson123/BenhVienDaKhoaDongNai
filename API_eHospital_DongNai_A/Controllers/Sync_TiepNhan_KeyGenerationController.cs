namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_TiepNhan_KeyGenerationController : BaseController<Sync_TiepNhan_KeyGeneration, ISync_TiepNhan_KeyGenerationService>
    {
    private readonly ISync_TiepNhan_KeyGenerationService _Sync_TiepNhan_KeyGenerationService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_TiepNhan_KeyGenerationController(ISync_TiepNhan_KeyGenerationService Sync_TiepNhan_KeyGenerationService, IWebHostEnvironment WebHostEnvironment) : base(Sync_TiepNhan_KeyGenerationService, WebHostEnvironment)
    {
    _Sync_TiepNhan_KeyGenerationService = Sync_TiepNhan_KeyGenerationService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

