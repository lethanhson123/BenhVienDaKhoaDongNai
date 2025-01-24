namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChanPhauThuat_EkipController : BaseController<HoiChanPhauThuat_Ekip, IHoiChanPhauThuat_EkipService>
    {
    private readonly IHoiChanPhauThuat_EkipService _HoiChanPhauThuat_EkipService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChanPhauThuat_EkipController(IHoiChanPhauThuat_EkipService HoiChanPhauThuat_EkipService, IWebHostEnvironment WebHostEnvironment) : base(HoiChanPhauThuat_EkipService, WebHostEnvironment)
    {
    _HoiChanPhauThuat_EkipService = HoiChanPhauThuat_EkipService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

