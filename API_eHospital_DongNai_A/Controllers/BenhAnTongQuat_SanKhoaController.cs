namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_SanKhoaController : BaseController<BenhAnTongQuat_SanKhoa, IBenhAnTongQuat_SanKhoaService>
    {
    private readonly IBenhAnTongQuat_SanKhoaService _BenhAnTongQuat_SanKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_SanKhoaController(IBenhAnTongQuat_SanKhoaService BenhAnTongQuat_SanKhoaService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_SanKhoaService, WebHostEnvironment)
    {
    _BenhAnTongQuat_SanKhoaService = BenhAnTongQuat_SanKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

