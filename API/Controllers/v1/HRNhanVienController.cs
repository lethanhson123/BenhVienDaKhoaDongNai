namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRNhanVienController : BaseController<HRNhanVien, IHRNhanVienService>
    {
    private readonly IHRNhanVienService _HRNhanVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRNhanVienController(IHRNhanVienService HRNhanVienService, IWebHostEnvironment WebHostEnvironment) : base(HRNhanVienService, WebHostEnvironment)
    {
    _HRNhanVienService = HRNhanVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

