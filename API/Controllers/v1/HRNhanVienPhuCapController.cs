namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRNhanVienPhuCapController : BaseController<HRNhanVienPhuCap, IHRNhanVienPhuCapService>
    {
    private readonly IHRNhanVienPhuCapService _HRNhanVienPhuCapService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRNhanVienPhuCapController(IHRNhanVienPhuCapService HRNhanVienPhuCapService, IWebHostEnvironment WebHostEnvironment) : base(HRNhanVienPhuCapService, WebHostEnvironment)
    {
    _HRNhanVienPhuCapService = HRNhanVienPhuCapService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

