namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRNhanVienHopDongController : BaseController<HRNhanVienHopDong, IHRNhanVienHopDongService>
    {
    private readonly IHRNhanVienHopDongService _HRNhanVienHopDongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRNhanVienHopDongController(IHRNhanVienHopDongService HRNhanVienHopDongService, IWebHostEnvironment WebHostEnvironment) : base(HRNhanVienHopDongService, WebHostEnvironment)
    {
    _HRNhanVienHopDongService = HRNhanVienHopDongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

