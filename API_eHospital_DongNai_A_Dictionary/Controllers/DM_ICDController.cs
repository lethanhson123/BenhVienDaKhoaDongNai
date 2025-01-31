namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ICDController : BaseController<DM_ICD, IDM_ICDService>
    {
    private readonly IDM_ICDService _DM_ICDService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_ICDController(IDM_ICDService DM_ICDService, IWebHostEnvironment WebHostEnvironment) : base(DM_ICDService, WebHostEnvironment)
    {
    _DM_ICDService = DM_ICDService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

