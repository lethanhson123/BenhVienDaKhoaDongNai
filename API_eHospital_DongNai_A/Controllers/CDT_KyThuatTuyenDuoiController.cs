namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KyThuatTuyenDuoiController : BaseController<CDT_KyThuatTuyenDuoi, ICDT_KyThuatTuyenDuoiService>
    {
    private readonly ICDT_KyThuatTuyenDuoiService _CDT_KyThuatTuyenDuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KyThuatTuyenDuoiController(ICDT_KyThuatTuyenDuoiService CDT_KyThuatTuyenDuoiService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KyThuatTuyenDuoiService, WebHostEnvironment)
    {
    _CDT_KyThuatTuyenDuoiService = CDT_KyThuatTuyenDuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

