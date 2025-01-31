namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ICD_NhomController : BaseController<DM_ICD_Nhom, IDM_ICD_NhomService>
    {
    private readonly IDM_ICD_NhomService _DM_ICD_NhomService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_ICD_NhomController(IDM_ICD_NhomService DM_ICD_NhomService, IWebHostEnvironment WebHostEnvironment) : base(DM_ICD_NhomService, WebHostEnvironment)
    {
    _DM_ICD_NhomService = DM_ICD_NhomService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

