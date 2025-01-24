namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_TAIKHOANController : BaseController<DM_TAIKHOAN, IDM_TAIKHOANService>
    {
    private readonly IDM_TAIKHOANService _DM_TAIKHOANService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_TAIKHOANController(IDM_TAIKHOANService DM_TAIKHOANService, IWebHostEnvironment WebHostEnvironment) : base(DM_TAIKHOANService, WebHostEnvironment)
    {
    _DM_TAIKHOANService = DM_TAIKHOANService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

