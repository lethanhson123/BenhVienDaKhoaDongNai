namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_DM_BenhNhan_KeyGenerationController : BaseController<Sync_DM_BenhNhan_KeyGeneration, ISync_DM_BenhNhan_KeyGenerationService>
    {
    private readonly ISync_DM_BenhNhan_KeyGenerationService _Sync_DM_BenhNhan_KeyGenerationService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_DM_BenhNhan_KeyGenerationController(ISync_DM_BenhNhan_KeyGenerationService Sync_DM_BenhNhan_KeyGenerationService, IWebHostEnvironment WebHostEnvironment) : base(Sync_DM_BenhNhan_KeyGenerationService, WebHostEnvironment)
    {
    _Sync_DM_BenhNhan_KeyGenerationService = Sync_DM_BenhNhan_KeyGenerationService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

