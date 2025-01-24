namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_GCVController : BaseController<BenhAnTongQuat_GCV, IBenhAnTongQuat_GCVService>
    {
    private readonly IBenhAnTongQuat_GCVService _BenhAnTongQuat_GCVService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_GCVController(IBenhAnTongQuat_GCVService BenhAnTongQuat_GCVService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_GCVService, WebHostEnvironment)
    {
    _BenhAnTongQuat_GCVService = BenhAnTongQuat_GCVService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

