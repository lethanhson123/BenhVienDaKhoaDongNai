namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_NhanSuTuyenDuoiController : BaseController<CDT_NhanSuTuyenDuoi, ICDT_NhanSuTuyenDuoiService>
    {
    private readonly ICDT_NhanSuTuyenDuoiService _CDT_NhanSuTuyenDuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_NhanSuTuyenDuoiController(ICDT_NhanSuTuyenDuoiService CDT_NhanSuTuyenDuoiService, IWebHostEnvironment WebHostEnvironment) : base(CDT_NhanSuTuyenDuoiService, WebHostEnvironment)
    {
    _CDT_NhanSuTuyenDuoiService = CDT_NhanSuTuyenDuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

