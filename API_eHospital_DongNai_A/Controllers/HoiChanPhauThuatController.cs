namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoiChanPhauThuatController : BaseController<HoiChanPhauThuat, IHoiChanPhauThuatService>
    {
    private readonly IHoiChanPhauThuatService _HoiChanPhauThuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HoiChanPhauThuatController(IHoiChanPhauThuatService HoiChanPhauThuatService, IWebHostEnvironment WebHostEnvironment) : base(HoiChanPhauThuatService, WebHostEnvironment)
    {
    _HoiChanPhauThuatService = HoiChanPhauThuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

