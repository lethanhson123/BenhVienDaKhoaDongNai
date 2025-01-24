namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_GBTController : BaseController<BenhAnTongQuat_GBT, IBenhAnTongQuat_GBTService>
    {
    private readonly IBenhAnTongQuat_GBTService _BenhAnTongQuat_GBTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_GBTController(IBenhAnTongQuat_GBTService BenhAnTongQuat_GBTService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_GBTService, WebHostEnvironment)
    {
    _BenhAnTongQuat_GBTService = BenhAnTongQuat_GBTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

