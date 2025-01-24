namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_LichCongTacController : BaseController<CDT_LichCongTac, ICDT_LichCongTacService>
    {
    private readonly ICDT_LichCongTacService _CDT_LichCongTacService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_LichCongTacController(ICDT_LichCongTacService CDT_LichCongTacService, IWebHostEnvironment WebHostEnvironment) : base(CDT_LichCongTacService, WebHostEnvironment)
    {
    _CDT_LichCongTacService = CDT_LichCongTacService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

