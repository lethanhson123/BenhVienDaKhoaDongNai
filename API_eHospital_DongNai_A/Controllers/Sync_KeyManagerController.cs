namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_KeyManagerController : BaseController<Sync_KeyManager, ISync_KeyManagerService>
    {
    private readonly ISync_KeyManagerService _Sync_KeyManagerService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_KeyManagerController(ISync_KeyManagerService Sync_KeyManagerService, IWebHostEnvironment WebHostEnvironment) : base(Sync_KeyManagerService, WebHostEnvironment)
    {
    _Sync_KeyManagerService = Sync_KeyManagerService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

