namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_GiayChungSinhController : BaseController<BenhAnTongQuat_GiayChungSinh, IBenhAnTongQuat_GiayChungSinhService>
    {
    private readonly IBenhAnTongQuat_GiayChungSinhService _BenhAnTongQuat_GiayChungSinhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_GiayChungSinhController(IBenhAnTongQuat_GiayChungSinhService BenhAnTongQuat_GiayChungSinhService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_GiayChungSinhService, WebHostEnvironment)
    {
    _BenhAnTongQuat_GiayChungSinhService = BenhAnTongQuat_GiayChungSinhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

