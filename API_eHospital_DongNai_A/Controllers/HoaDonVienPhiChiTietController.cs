namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDonVienPhiChiTietController : BaseController<HoaDonVienPhiChiTiet, IHoaDonVienPhiChiTietService>
    {
    private readonly IHoaDonVienPhiChiTietService _HoaDonVienPhiChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoaDonVienPhiChiTietController(IHoaDonVienPhiChiTietService HoaDonVienPhiChiTietService, IWebHostEnvironment WebHostEnvironment) : base(HoaDonVienPhiChiTietService, WebHostEnvironment)
    {
    _HoaDonVienPhiChiTietService = HoaDonVienPhiChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

