namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_SoSinhController : BaseController<BenhAnTongQuat_SoSinh, IBenhAnTongQuat_SoSinhService>
    {
    private readonly IBenhAnTongQuat_SoSinhService _BenhAnTongQuat_SoSinhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_SoSinhController(IBenhAnTongQuat_SoSinhService BenhAnTongQuat_SoSinhService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_SoSinhService, WebHostEnvironment)
    {
    _BenhAnTongQuat_SoSinhService = BenhAnTongQuat_SoSinhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

