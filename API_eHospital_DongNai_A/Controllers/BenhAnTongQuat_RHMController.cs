namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_RHMController : BaseController<BenhAnTongQuat_RHM, IBenhAnTongQuat_RHMService>
    {
    private readonly IBenhAnTongQuat_RHMService _BenhAnTongQuat_RHMService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_RHMController(IBenhAnTongQuat_RHMService BenhAnTongQuat_RHMService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_RHMService, WebHostEnvironment)
    {
    _BenhAnTongQuat_RHMService = BenhAnTongQuat_RHMService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

