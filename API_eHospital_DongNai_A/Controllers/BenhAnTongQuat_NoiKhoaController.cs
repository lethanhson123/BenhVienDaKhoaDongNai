namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_NoiKhoaController : BaseController<BenhAnTongQuat_NoiKhoa, IBenhAnTongQuat_NoiKhoaService>
    {
    private readonly IBenhAnTongQuat_NoiKhoaService _BenhAnTongQuat_NoiKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_NoiKhoaController(IBenhAnTongQuat_NoiKhoaService BenhAnTongQuat_NoiKhoaService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_NoiKhoaService, WebHostEnvironment)
    {
    _BenhAnTongQuat_NoiKhoaService = BenhAnTongQuat_NoiKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

