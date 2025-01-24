namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_TangThePhuController : BaseController<CSKH_The_TangThePhu, ICSKH_The_TangThePhuService>
    {
    private readonly ICSKH_The_TangThePhuService _CSKH_The_TangThePhuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_TangThePhuController(ICSKH_The_TangThePhuService CSKH_The_TangThePhuService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_TangThePhuService, WebHostEnvironment)
    {
    _CSKH_The_TangThePhuService = CSKH_The_TangThePhuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

