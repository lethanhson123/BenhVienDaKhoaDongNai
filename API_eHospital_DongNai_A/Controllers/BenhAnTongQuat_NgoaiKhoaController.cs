namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_NgoaiKhoaController : BaseController<BenhAnTongQuat_NgoaiKhoa, IBenhAnTongQuat_NgoaiKhoaService>
    {
    private readonly IBenhAnTongQuat_NgoaiKhoaService _BenhAnTongQuat_NgoaiKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_NgoaiKhoaController(IBenhAnTongQuat_NgoaiKhoaService BenhAnTongQuat_NgoaiKhoaService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_NgoaiKhoaService, WebHostEnvironment)
    {
    _BenhAnTongQuat_NgoaiKhoaService = BenhAnTongQuat_NgoaiKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

