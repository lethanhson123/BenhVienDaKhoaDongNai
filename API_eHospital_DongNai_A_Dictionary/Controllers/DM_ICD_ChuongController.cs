namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ICD_ChuongController : BaseController<DM_ICD_Chuong, IDM_ICD_ChuongService>
    {
    private readonly IDM_ICD_ChuongService _DM_ICD_ChuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_ICD_ChuongController(IDM_ICD_ChuongService DM_ICD_ChuongService, IWebHostEnvironment WebHostEnvironment) : base(DM_ICD_ChuongService, WebHostEnvironment)
    {
    _DM_ICD_ChuongService = DM_ICD_ChuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

