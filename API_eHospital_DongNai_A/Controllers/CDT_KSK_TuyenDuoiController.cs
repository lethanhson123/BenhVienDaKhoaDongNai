namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KSK_TuyenDuoiController : BaseController<CDT_KSK_TuyenDuoi, ICDT_KSK_TuyenDuoiService>
    {
    private readonly ICDT_KSK_TuyenDuoiService _CDT_KSK_TuyenDuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KSK_TuyenDuoiController(ICDT_KSK_TuyenDuoiService CDT_KSK_TuyenDuoiService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KSK_TuyenDuoiService, WebHostEnvironment)
    {
    _CDT_KSK_TuyenDuoiService = CDT_KSK_TuyenDuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

