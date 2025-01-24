namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_LienQuanBenhController : BaseController<BenhAnTongQuat_LienQuanBenh, IBenhAnTongQuat_LienQuanBenhService>
    {
    private readonly IBenhAnTongQuat_LienQuanBenhService _BenhAnTongQuat_LienQuanBenhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_LienQuanBenhController(IBenhAnTongQuat_LienQuanBenhService BenhAnTongQuat_LienQuanBenhService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_LienQuanBenhService, WebHostEnvironment)
    {
    _BenhAnTongQuat_LienQuanBenhService = BenhAnTongQuat_LienQuanBenhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

