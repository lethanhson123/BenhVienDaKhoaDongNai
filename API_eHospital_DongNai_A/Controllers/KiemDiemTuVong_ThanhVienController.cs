namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KiemDiemTuVong_ThanhVienController : BaseController<KiemDiemTuVong_ThanhVien, IKiemDiemTuVong_ThanhVienService>
    {
    private readonly IKiemDiemTuVong_ThanhVienService _KiemDiemTuVong_ThanhVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KiemDiemTuVong_ThanhVienController(IKiemDiemTuVong_ThanhVienService KiemDiemTuVong_ThanhVienService, IWebHostEnvironment WebHostEnvironment) : base(KiemDiemTuVong_ThanhVienService, WebHostEnvironment)
    {
    _KiemDiemTuVong_ThanhVienService = KiemDiemTuVong_ThanhVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

