namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRChamCongChiTietController : BaseController<HRChamCongChiTiet, IHRChamCongChiTietService>
    {
    private readonly IHRChamCongChiTietService _HRChamCongChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRChamCongChiTietController(IHRChamCongChiTietService HRChamCongChiTietService, IWebHostEnvironment WebHostEnvironment) : base(HRChamCongChiTietService, WebHostEnvironment)
    {
    _HRChamCongChiTietService = HRChamCongChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

