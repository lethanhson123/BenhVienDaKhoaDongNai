namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_DieuTriTuyenDuoiController : BaseController<CDT_DieuTriTuyenDuoi, ICDT_DieuTriTuyenDuoiService>
    {
    private readonly ICDT_DieuTriTuyenDuoiService _CDT_DieuTriTuyenDuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_DieuTriTuyenDuoiController(ICDT_DieuTriTuyenDuoiService CDT_DieuTriTuyenDuoiService, IWebHostEnvironment WebHostEnvironment) : base(CDT_DieuTriTuyenDuoiService, WebHostEnvironment)
    {
    _CDT_DieuTriTuyenDuoiService = CDT_DieuTriTuyenDuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

