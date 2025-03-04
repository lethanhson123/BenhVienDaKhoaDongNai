namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HRBangLuongController : BaseController<HRBangLuong, IHRBangLuongService>
    {
    private readonly IHRBangLuongService _HRBangLuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HRBangLuongController(IHRBangLuongService HRBangLuongService, IWebHostEnvironment WebHostEnvironment) : base(HRBangLuongService, WebHostEnvironment)
    {
    _HRBangLuongService = HRBangLuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

