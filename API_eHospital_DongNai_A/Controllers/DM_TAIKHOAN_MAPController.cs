namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_TAIKHOAN_MAPController : BaseController<DM_TAIKHOAN_MAP, IDM_TAIKHOAN_MAPService>
    {
    private readonly IDM_TAIKHOAN_MAPService _DM_TAIKHOAN_MAPService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_TAIKHOAN_MAPController(IDM_TAIKHOAN_MAPService DM_TAIKHOAN_MAPService, IWebHostEnvironment WebHostEnvironment) : base(DM_TAIKHOAN_MAPService, WebHostEnvironment)
    {
    _DM_TAIKHOAN_MAPService = DM_TAIKHOAN_MAPService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

