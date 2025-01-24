namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_HopDong_GoiDichVuController : BaseController<KSK_HopDong_GoiDichVu, IKSK_HopDong_GoiDichVuService>
    {
    private readonly IKSK_HopDong_GoiDichVuService _KSK_HopDong_GoiDichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_HopDong_GoiDichVuController(IKSK_HopDong_GoiDichVuService KSK_HopDong_GoiDichVuService, IWebHostEnvironment WebHostEnvironment) : base(KSK_HopDong_GoiDichVuService, WebHostEnvironment)
    {
    _KSK_HopDong_GoiDichVuService = KSK_HopDong_GoiDichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

