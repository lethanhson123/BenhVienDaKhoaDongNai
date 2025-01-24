namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDon_ThuTuController : BaseController<HoaDon_ThuTu, IHoaDon_ThuTuService>
    {
    private readonly IHoaDon_ThuTuService _HoaDon_ThuTuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoaDon_ThuTuController(IHoaDon_ThuTuService HoaDon_ThuTuService, IWebHostEnvironment WebHostEnvironment) : base(HoaDon_ThuTuService, WebHostEnvironment)
    {
    _HoaDon_ThuTuService = HoaDon_ThuTuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

