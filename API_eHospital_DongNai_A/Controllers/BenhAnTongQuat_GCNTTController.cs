namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_GCNTTController : BaseController<BenhAnTongQuat_GCNTT, IBenhAnTongQuat_GCNTTService>
    {
    private readonly IBenhAnTongQuat_GCNTTService _BenhAnTongQuat_GCNTTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_GCNTTController(IBenhAnTongQuat_GCNTTService BenhAnTongQuat_GCNTTService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_GCNTTService, WebHostEnvironment)
    {
    _BenhAnTongQuat_GCNTTService = BenhAnTongQuat_GCNTTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

