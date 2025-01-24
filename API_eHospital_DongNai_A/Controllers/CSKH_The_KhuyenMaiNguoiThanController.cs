namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_KhuyenMaiNguoiThanController : BaseController<CSKH_The_KhuyenMaiNguoiThan, ICSKH_The_KhuyenMaiNguoiThanService>
    {
    private readonly ICSKH_The_KhuyenMaiNguoiThanService _CSKH_The_KhuyenMaiNguoiThanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_KhuyenMaiNguoiThanController(ICSKH_The_KhuyenMaiNguoiThanService CSKH_The_KhuyenMaiNguoiThanService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_KhuyenMaiNguoiThanService, WebHostEnvironment)
    {
    _CSKH_The_KhuyenMaiNguoiThanService = CSKH_The_KhuyenMaiNguoiThanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

