namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DVT_ThoiGianController : BaseController<DM_DVT_ThoiGian, IDM_DVT_ThoiGianService>
    {
    private readonly IDM_DVT_ThoiGianService _DM_DVT_ThoiGianService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DVT_ThoiGianController(IDM_DVT_ThoiGianService DM_DVT_ThoiGianService, IWebHostEnvironment WebHostEnvironment) : base(DM_DVT_ThoiGianService, WebHostEnvironment)
    {
    _DM_DVT_ThoiGianService = DM_DVT_ThoiGianService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

