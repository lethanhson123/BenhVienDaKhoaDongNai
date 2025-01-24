namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_Duoc_DungChungController : BaseController<DM_Duoc_DungChung, IDM_Duoc_DungChungService>
    {
    private readonly IDM_Duoc_DungChungService _DM_Duoc_DungChungService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_Duoc_DungChungController(IDM_Duoc_DungChungService DM_Duoc_DungChungService, IWebHostEnvironment WebHostEnvironment) : base(DM_Duoc_DungChungService, WebHostEnvironment)
    {
    _DM_Duoc_DungChungService = DM_Duoc_DungChungService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

