namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoSoLienThongSoYTeController : BaseController<HoSoLienThongSoYTe, IHoSoLienThongSoYTeService>
    {
    private readonly IHoSoLienThongSoYTeService _HoSoLienThongSoYTeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoSoLienThongSoYTeController(IHoSoLienThongSoYTeService HoSoLienThongSoYTeService, IWebHostEnvironment WebHostEnvironment) : base(HoSoLienThongSoYTeService, WebHostEnvironment)
    {
    _HoSoLienThongSoYTeService = HoSoLienThongSoYTeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

