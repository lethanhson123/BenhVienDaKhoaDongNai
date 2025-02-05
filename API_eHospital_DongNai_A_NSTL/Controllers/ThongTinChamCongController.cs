namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongTinChamCongController : BaseController<ThongTinChamCong, IThongTinChamCongService>
    {
    private readonly IThongTinChamCongService _ThongTinChamCongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThongTinChamCongController(IThongTinChamCongService ThongTinChamCongService, IWebHostEnvironment WebHostEnvironment) : base(ThongTinChamCongService, WebHostEnvironment)
    {
    _ThongTinChamCongService = ThongTinChamCongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

