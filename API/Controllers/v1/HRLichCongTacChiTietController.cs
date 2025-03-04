namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRLichCongTacChiTietController : BaseController<HRLichCongTacChiTiet, IHRLichCongTacChiTietService>
    {
    private readonly IHRLichCongTacChiTietService _HRLichCongTacChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRLichCongTacChiTietController(IHRLichCongTacChiTietService HRLichCongTacChiTietService, IWebHostEnvironment WebHostEnvironment) : base(HRLichCongTacChiTietService, WebHostEnvironment)
    {
    _HRLichCongTacChiTietService = HRLichCongTacChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

