namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_DM_LoaiKhachHangController : BaseController<CSKH_DM_LoaiKhachHang, ICSKH_DM_LoaiKhachHangService>
    {
    private readonly ICSKH_DM_LoaiKhachHangService _CSKH_DM_LoaiKhachHangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_DM_LoaiKhachHangController(ICSKH_DM_LoaiKhachHangService CSKH_DM_LoaiKhachHangService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_DM_LoaiKhachHangService, WebHostEnvironment)
    {
    _CSKH_DM_LoaiKhachHangService = CSKH_DM_LoaiKhachHangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

