namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDonVienPhiController : BaseController<HoaDonVienPhi, IHoaDonVienPhiService>
    {
    private readonly IHoaDonVienPhiService _HoaDonVienPhiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoaDonVienPhiController(IHoaDonVienPhiService HoaDonVienPhiService, IWebHostEnvironment WebHostEnvironment) : base(HoaDonVienPhiService, WebHostEnvironment)
    {
    _HoaDonVienPhiService = HoaDonVienPhiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

