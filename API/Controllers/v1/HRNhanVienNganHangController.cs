namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRNhanVienNganHangController : BaseController<HRNhanVienNganHang, IHRNhanVienNganHangService>
    {
    private readonly IHRNhanVienNganHangService _HRNhanVienNganHangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRNhanVienNganHangController(IHRNhanVienNganHangService HRNhanVienNganHangService, IWebHostEnvironment WebHostEnvironment) : base(HRNhanVienNganHangService, WebHostEnvironment)
    {
    _HRNhanVienNganHangService = HRNhanVienNganHangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

