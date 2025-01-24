namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_KhuyenMaiNapTienController : BaseController<CSKH_The_KhuyenMaiNapTien, ICSKH_The_KhuyenMaiNapTienService>
    {
    private readonly ICSKH_The_KhuyenMaiNapTienService _CSKH_The_KhuyenMaiNapTienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_KhuyenMaiNapTienController(ICSKH_The_KhuyenMaiNapTienService CSKH_The_KhuyenMaiNapTienService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_KhuyenMaiNapTienService, WebHostEnvironment)
    {
    _CSKH_The_KhuyenMaiNapTienService = CSKH_The_KhuyenMaiNapTienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

