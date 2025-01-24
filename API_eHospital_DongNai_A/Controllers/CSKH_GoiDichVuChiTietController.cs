namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_GoiDichVuChiTietController : BaseController<CSKH_GoiDichVuChiTiet, ICSKH_GoiDichVuChiTietService>
    {
    private readonly ICSKH_GoiDichVuChiTietService _CSKH_GoiDichVuChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_GoiDichVuChiTietController(ICSKH_GoiDichVuChiTietService CSKH_GoiDichVuChiTietService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_GoiDichVuChiTietService, WebHostEnvironment)
    {
    _CSKH_GoiDichVuChiTietService = CSKH_GoiDichVuChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

