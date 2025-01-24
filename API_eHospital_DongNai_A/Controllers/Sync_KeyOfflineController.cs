namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_KeyOfflineController : BaseController<Sync_KeyOffline, ISync_KeyOfflineService>
    {
    private readonly ISync_KeyOfflineService _Sync_KeyOfflineService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_KeyOfflineController(ISync_KeyOfflineService Sync_KeyOfflineService, IWebHostEnvironment WebHostEnvironment) : base(Sync_KeyOfflineService, WebHostEnvironment)
    {
    _Sync_KeyOfflineService = Sync_KeyOfflineService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

