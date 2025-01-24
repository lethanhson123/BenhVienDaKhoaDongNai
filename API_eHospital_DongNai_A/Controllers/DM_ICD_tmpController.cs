namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ICD_tmpController : BaseController<DM_ICD_tmp, IDM_ICD_tmpService>
    {
    private readonly IDM_ICD_tmpService _DM_ICD_tmpService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_ICD_tmpController(IDM_ICD_tmpService DM_ICD_tmpService, IWebHostEnvironment WebHostEnvironment) : base(DM_ICD_tmpService, WebHostEnvironment)
    {
    _DM_ICD_tmpService = DM_ICD_tmpService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

