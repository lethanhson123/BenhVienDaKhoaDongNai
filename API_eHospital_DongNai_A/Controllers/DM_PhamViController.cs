namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_PhamViController : BaseController<DM_PhamVi, IDM_PhamViService>
    {
    private readonly IDM_PhamViService _DM_PhamViService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_PhamViController(IDM_PhamViService DM_PhamViService, IWebHostEnvironment WebHostEnvironment) : base(DM_PhamViService, WebHostEnvironment)
    {
    _DM_PhamViService = DM_PhamViService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

