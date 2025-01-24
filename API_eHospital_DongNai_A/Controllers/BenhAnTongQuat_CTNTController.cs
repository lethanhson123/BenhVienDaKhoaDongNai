namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_CTNTController : BaseController<BenhAnTongQuat_CTNT, IBenhAnTongQuat_CTNTService>
    {
    private readonly IBenhAnTongQuat_CTNTService _BenhAnTongQuat_CTNTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_CTNTController(IBenhAnTongQuat_CTNTService BenhAnTongQuat_CTNTService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_CTNTService, WebHostEnvironment)
    {
    _BenhAnTongQuat_CTNTService = BenhAnTongQuat_CTNTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

