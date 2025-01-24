namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_HopDong_DichVuController : BaseController<KSK_HopDong_DichVu, IKSK_HopDong_DichVuService>
    {
    private readonly IKSK_HopDong_DichVuService _KSK_HopDong_DichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_HopDong_DichVuController(IKSK_HopDong_DichVuService KSK_HopDong_DichVuService, IWebHostEnvironment WebHostEnvironment) : base(KSK_HopDong_DichVuService, WebHostEnvironment)
    {
    _KSK_HopDong_DichVuService = KSK_HopDong_DichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

