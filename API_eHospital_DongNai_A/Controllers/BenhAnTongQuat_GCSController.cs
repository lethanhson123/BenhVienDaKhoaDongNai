namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_GCSController : BaseController<BenhAnTongQuat_GCS, IBenhAnTongQuat_GCSService>
    {
    private readonly IBenhAnTongQuat_GCSService _BenhAnTongQuat_GCSService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_GCSController(IBenhAnTongQuat_GCSService BenhAnTongQuat_GCSService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_GCSService, WebHostEnvironment)
    {
    _BenhAnTongQuat_GCSService = BenhAnTongQuat_GCSService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

