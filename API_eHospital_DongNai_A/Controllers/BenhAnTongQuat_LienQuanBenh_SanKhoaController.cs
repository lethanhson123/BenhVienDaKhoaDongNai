namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_LienQuanBenh_SanKhoaController : BaseController<BenhAnTongQuat_LienQuanBenh_SanKhoa, IBenhAnTongQuat_LienQuanBenh_SanKhoaService>
    {
    private readonly IBenhAnTongQuat_LienQuanBenh_SanKhoaService _BenhAnTongQuat_LienQuanBenh_SanKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_LienQuanBenh_SanKhoaController(IBenhAnTongQuat_LienQuanBenh_SanKhoaService BenhAnTongQuat_LienQuanBenh_SanKhoaService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_LienQuanBenh_SanKhoaService, WebHostEnvironment)
    {
    _BenhAnTongQuat_LienQuanBenh_SanKhoaService = BenhAnTongQuat_LienQuanBenh_SanKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

