namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_PhuKhoaController : BaseController<BenhAnTongQuat_PhuKhoa, IBenhAnTongQuat_PhuKhoaService>
    {
    private readonly IBenhAnTongQuat_PhuKhoaService _BenhAnTongQuat_PhuKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_PhuKhoaController(IBenhAnTongQuat_PhuKhoaService BenhAnTongQuat_PhuKhoaService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_PhuKhoaService, WebHostEnvironment)
    {
    _BenhAnTongQuat_PhuKhoaService = BenhAnTongQuat_PhuKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

