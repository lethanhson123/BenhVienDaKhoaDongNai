namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_KyThuatController : BaseController<DM_KyThuat, IDM_KyThuatService>
    {
    private readonly IDM_KyThuatService _DM_KyThuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_KyThuatController(IDM_KyThuatService DM_KyThuatService, IWebHostEnvironment WebHostEnvironment) : base(DM_KyThuatService, WebHostEnvironment)
    {
    _DM_KyThuatService = DM_KyThuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

