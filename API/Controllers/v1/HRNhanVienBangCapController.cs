namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRNhanVienBangCapController : BaseController<HRNhanVienBangCap, IHRNhanVienBangCapService>
    {
    private readonly IHRNhanVienBangCapService _HRNhanVienBangCapService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRNhanVienBangCapController(IHRNhanVienBangCapService HRNhanVienBangCapService, IWebHostEnvironment WebHostEnvironment) : base(HRNhanVienBangCapService, WebHostEnvironment)
    {
    _HRNhanVienBangCapService = HRNhanVienBangCapService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

