namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChan_EkipController : BaseController<HoiChan_Ekip, IHoiChan_EkipService>
    {
    private readonly IHoiChan_EkipService _HoiChan_EkipService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChan_EkipController(IHoiChan_EkipService HoiChan_EkipService, IWebHostEnvironment WebHostEnvironment) : base(HoiChan_EkipService, WebHostEnvironment)
    {
    _HoiChan_EkipService = HoiChan_EkipService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

