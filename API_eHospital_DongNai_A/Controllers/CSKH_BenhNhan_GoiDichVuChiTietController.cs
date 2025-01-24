namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_BenhNhan_GoiDichVuChiTietController : BaseController<CSKH_BenhNhan_GoiDichVuChiTiet, ICSKH_BenhNhan_GoiDichVuChiTietService>
    {
    private readonly ICSKH_BenhNhan_GoiDichVuChiTietService _CSKH_BenhNhan_GoiDichVuChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_BenhNhan_GoiDichVuChiTietController(ICSKH_BenhNhan_GoiDichVuChiTietService CSKH_BenhNhan_GoiDichVuChiTietService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_BenhNhan_GoiDichVuChiTietService, WebHostEnvironment)
    {
    _CSKH_BenhNhan_GoiDichVuChiTietService = CSKH_BenhNhan_GoiDichVuChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

