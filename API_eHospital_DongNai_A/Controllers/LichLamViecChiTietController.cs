namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LichLamViecChiTietController : BaseController<LichLamViecChiTiet, ILichLamViecChiTietService>
    {
    private readonly ILichLamViecChiTietService _LichLamViecChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LichLamViecChiTietController(ILichLamViecChiTietService LichLamViecChiTietService, IWebHostEnvironment WebHostEnvironment) : base(LichLamViecChiTietService, WebHostEnvironment)
    {
    _LichLamViecChiTietService = LichLamViecChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

