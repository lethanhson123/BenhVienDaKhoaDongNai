namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRBangLuongChiTietController : BaseController<HRBangLuongChiTiet, IHRBangLuongChiTietService>
    {
    private readonly IHRBangLuongChiTietService _HRBangLuongChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRBangLuongChiTietController(IHRBangLuongChiTietService HRBangLuongChiTietService, IWebHostEnvironment WebHostEnvironment) : base(HRBangLuongChiTietService, WebHostEnvironment)
    {
    _HRBangLuongChiTietService = HRBangLuongChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

