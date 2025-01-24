namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DoiTuongCDTController : BaseController<DM_DoiTuongCDT, IDM_DoiTuongCDTService>
    {
    private readonly IDM_DoiTuongCDTService _DM_DoiTuongCDTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DoiTuongCDTController(IDM_DoiTuongCDTService DM_DoiTuongCDTService, IWebHostEnvironment WebHostEnvironment) : base(DM_DoiTuongCDTService, WebHostEnvironment)
    {
    _DM_DoiTuongCDTService = DM_DoiTuongCDTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

