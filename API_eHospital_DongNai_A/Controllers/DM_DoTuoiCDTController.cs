namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DoTuoiCDTController : BaseController<DM_DoTuoiCDT, IDM_DoTuoiCDTService>
    {
    private readonly IDM_DoTuoiCDTService _DM_DoTuoiCDTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DoTuoiCDTController(IDM_DoTuoiCDTService DM_DoTuoiCDTService, IWebHostEnvironment WebHostEnvironment) : base(DM_DoTuoiCDTService, WebHostEnvironment)
    {
    _DM_DoTuoiCDTService = DM_DoTuoiCDTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

