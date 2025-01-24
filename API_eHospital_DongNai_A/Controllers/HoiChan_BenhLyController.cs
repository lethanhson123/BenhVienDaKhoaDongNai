namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChan_BenhLyController : BaseController<HoiChan_BenhLy, IHoiChan_BenhLyService>
    {
    private readonly IHoiChan_BenhLyService _HoiChan_BenhLyService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChan_BenhLyController(IHoiChan_BenhLyService HoiChan_BenhLyService, IWebHostEnvironment WebHostEnvironment) : base(HoiChan_BenhLyService, WebHostEnvironment)
    {
    _HoiChan_BenhLyService = HoiChan_BenhLyService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

