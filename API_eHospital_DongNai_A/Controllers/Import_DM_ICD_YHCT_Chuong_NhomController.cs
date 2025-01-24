namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Import_DM_ICD_YHCT_Chuong_NhomController : BaseController<Import_DM_ICD_YHCT_Chuong_Nhom, IImport_DM_ICD_YHCT_Chuong_NhomService>
    {
    private readonly IImport_DM_ICD_YHCT_Chuong_NhomService _Import_DM_ICD_YHCT_Chuong_NhomService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Import_DM_ICD_YHCT_Chuong_NhomController(IImport_DM_ICD_YHCT_Chuong_NhomService Import_DM_ICD_YHCT_Chuong_NhomService, IWebHostEnvironment WebHostEnvironment) : base(Import_DM_ICD_YHCT_Chuong_NhomService, WebHostEnvironment)
    {
    _Import_DM_ICD_YHCT_Chuong_NhomService = Import_DM_ICD_YHCT_Chuong_NhomService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

