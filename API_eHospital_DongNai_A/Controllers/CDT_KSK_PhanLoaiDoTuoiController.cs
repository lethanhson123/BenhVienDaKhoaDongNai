namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KSK_PhanLoaiDoTuoiController : BaseController<CDT_KSK_PhanLoaiDoTuoi, ICDT_KSK_PhanLoaiDoTuoiService>
    {
    private readonly ICDT_KSK_PhanLoaiDoTuoiService _CDT_KSK_PhanLoaiDoTuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KSK_PhanLoaiDoTuoiController(ICDT_KSK_PhanLoaiDoTuoiService CDT_KSK_PhanLoaiDoTuoiService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KSK_PhanLoaiDoTuoiService, WebHostEnvironment)
    {
    _CDT_KSK_PhanLoaiDoTuoiService = CDT_KSK_PhanLoaiDoTuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

