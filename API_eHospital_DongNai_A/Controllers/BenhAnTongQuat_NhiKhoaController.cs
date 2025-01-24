namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_NhiKhoaController : BaseController<BenhAnTongQuat_NhiKhoa, IBenhAnTongQuat_NhiKhoaService>
    {
    private readonly IBenhAnTongQuat_NhiKhoaService _BenhAnTongQuat_NhiKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_NhiKhoaController(IBenhAnTongQuat_NhiKhoaService BenhAnTongQuat_NhiKhoaService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_NhiKhoaService, WebHostEnvironment)
    {
    _BenhAnTongQuat_NhiKhoaService = BenhAnTongQuat_NhiKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

