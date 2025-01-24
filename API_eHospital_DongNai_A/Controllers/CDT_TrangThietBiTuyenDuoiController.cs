namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_TrangThietBiTuyenDuoiController : BaseController<CDT_TrangThietBiTuyenDuoi, ICDT_TrangThietBiTuyenDuoiService>
    {
    private readonly ICDT_TrangThietBiTuyenDuoiService _CDT_TrangThietBiTuyenDuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_TrangThietBiTuyenDuoiController(ICDT_TrangThietBiTuyenDuoiService CDT_TrangThietBiTuyenDuoiService, IWebHostEnvironment WebHostEnvironment) : base(CDT_TrangThietBiTuyenDuoiService, WebHostEnvironment)
    {
    _CDT_TrangThietBiTuyenDuoiService = CDT_TrangThietBiTuyenDuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

