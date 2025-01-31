namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ICD_CommonController : BaseController<DM_ICD_Common, IDM_ICD_CommonService>
    {
    private readonly IDM_ICD_CommonService _DM_ICD_CommonService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_ICD_CommonController(IDM_ICD_CommonService DM_ICD_CommonService, IWebHostEnvironment WebHostEnvironment) : base(DM_ICD_CommonService, WebHostEnvironment)
    {
    _DM_ICD_CommonService = DM_ICD_CommonService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

