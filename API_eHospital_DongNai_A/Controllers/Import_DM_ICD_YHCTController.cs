namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Import_DM_ICD_YHCTController : BaseController<Import_DM_ICD_YHCT, IImport_DM_ICD_YHCTService>
    {
    private readonly IImport_DM_ICD_YHCTService _Import_DM_ICD_YHCTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Import_DM_ICD_YHCTController(IImport_DM_ICD_YHCTService Import_DM_ICD_YHCTService, IWebHostEnvironment WebHostEnvironment) : base(Import_DM_ICD_YHCTService, WebHostEnvironment)
    {
    _Import_DM_ICD_YHCTService = Import_DM_ICD_YHCTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

