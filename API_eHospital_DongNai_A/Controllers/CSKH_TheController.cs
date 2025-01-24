namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_TheController : BaseController<CSKH_The, ICSKH_TheService>
    {
    private readonly ICSKH_TheService _CSKH_TheService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_TheController(ICSKH_TheService CSKH_TheService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_TheService, WebHostEnvironment)
    {
    _CSKH_TheService = CSKH_TheService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

