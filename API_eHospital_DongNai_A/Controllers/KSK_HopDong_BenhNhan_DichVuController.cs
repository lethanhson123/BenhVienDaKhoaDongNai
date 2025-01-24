namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KSK_HopDong_BenhNhan_DichVuController : BaseController<KSK_HopDong_BenhNhan_DichVu, IKSK_HopDong_BenhNhan_DichVuService>
    {
    private readonly IKSK_HopDong_BenhNhan_DichVuService _KSK_HopDong_BenhNhan_DichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KSK_HopDong_BenhNhan_DichVuController(IKSK_HopDong_BenhNhan_DichVuService KSK_HopDong_BenhNhan_DichVuService, IWebHostEnvironment WebHostEnvironment) : base(KSK_HopDong_BenhNhan_DichVuService, WebHostEnvironment)
    {
    _KSK_HopDong_BenhNhan_DichVuService = KSK_HopDong_BenhNhan_DichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

