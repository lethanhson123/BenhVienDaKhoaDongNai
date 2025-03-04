namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRNhanVienThanhVienController : BaseController<HRNhanVienThanhVien, IHRNhanVienThanhVienService>
    {
    private readonly IHRNhanVienThanhVienService _HRNhanVienThanhVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRNhanVienThanhVienController(IHRNhanVienThanhVienService HRNhanVienThanhVienService, IWebHostEnvironment WebHostEnvironment) : base(HRNhanVienThanhVienService, WebHostEnvironment)
    {
    _HRNhanVienThanhVienService = HRNhanVienThanhVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

