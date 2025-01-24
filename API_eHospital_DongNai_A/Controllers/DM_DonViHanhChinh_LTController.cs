namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DonViHanhChinh_LTController : BaseController<DM_DonViHanhChinh_LT, IDM_DonViHanhChinh_LTService>
    {
    private readonly IDM_DonViHanhChinh_LTService _DM_DonViHanhChinh_LTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DonViHanhChinh_LTController(IDM_DonViHanhChinh_LTService DM_DonViHanhChinh_LTService, IWebHostEnvironment WebHostEnvironment) : base(DM_DonViHanhChinh_LTService, WebHostEnvironment)
    {
    _DM_DonViHanhChinh_LTService = DM_DonViHanhChinh_LTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

