namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ICD_Chuong_tmpController : BaseController<DM_ICD_Chuong_tmp, IDM_ICD_Chuong_tmpService>
    {
    private readonly IDM_ICD_Chuong_tmpService _DM_ICD_Chuong_tmpService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_ICD_Chuong_tmpController(IDM_ICD_Chuong_tmpService DM_ICD_Chuong_tmpService, IWebHostEnvironment WebHostEnvironment) : base(DM_ICD_Chuong_tmpService, WebHostEnvironment)
    {
    _DM_ICD_Chuong_tmpService = DM_ICD_Chuong_tmpService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

