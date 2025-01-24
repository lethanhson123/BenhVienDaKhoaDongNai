namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_HopDong_BenhNhanController : BaseController<KSK_HopDong_BenhNhan, IKSK_HopDong_BenhNhanService>
    {
    private readonly IKSK_HopDong_BenhNhanService _KSK_HopDong_BenhNhanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_HopDong_BenhNhanController(IKSK_HopDong_BenhNhanService KSK_HopDong_BenhNhanService, IWebHostEnvironment WebHostEnvironment) : base(KSK_HopDong_BenhNhanService, WebHostEnvironment)
    {
    _KSK_HopDong_BenhNhanService = KSK_HopDong_BenhNhanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

