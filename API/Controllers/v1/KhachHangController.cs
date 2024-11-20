namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhachHangController : BaseController<KhachHang, IKhachHangService>
    {
    private readonly IKhachHangService _KhachHangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhachHangController(IKhachHangService KhachHangService, IWebHostEnvironment WebHostEnvironment) : base(KhachHangService, WebHostEnvironment)
    {
    _KhachHangService = KhachHangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

