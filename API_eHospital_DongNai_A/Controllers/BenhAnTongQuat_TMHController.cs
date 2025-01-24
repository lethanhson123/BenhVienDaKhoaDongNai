namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_TMHController : BaseController<BenhAnTongQuat_TMH, IBenhAnTongQuat_TMHService>
    {
    private readonly IBenhAnTongQuat_TMHService _BenhAnTongQuat_TMHService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_TMHController(IBenhAnTongQuat_TMHService BenhAnTongQuat_TMHService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_TMHService, WebHostEnvironment)
    {
    _BenhAnTongQuat_TMHService = BenhAnTongQuat_TMHService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

