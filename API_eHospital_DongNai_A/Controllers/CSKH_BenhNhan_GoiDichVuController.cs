namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_BenhNhan_GoiDichVuController : BaseController<CSKH_BenhNhan_GoiDichVu, ICSKH_BenhNhan_GoiDichVuService>
    {
    private readonly ICSKH_BenhNhan_GoiDichVuService _CSKH_BenhNhan_GoiDichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_BenhNhan_GoiDichVuController(ICSKH_BenhNhan_GoiDichVuService CSKH_BenhNhan_GoiDichVuService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_BenhNhan_GoiDichVuService, WebHostEnvironment)
    {
    _CSKH_BenhNhan_GoiDichVuService = CSKH_BenhNhan_GoiDichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

