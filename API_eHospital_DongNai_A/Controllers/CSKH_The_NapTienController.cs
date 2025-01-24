namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_NapTienController : BaseController<CSKH_The_NapTien, ICSKH_The_NapTienService>
    {
    private readonly ICSKH_The_NapTienService _CSKH_The_NapTienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_NapTienController(ICSKH_The_NapTienService CSKH_The_NapTienService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_NapTienService, WebHostEnvironment)
    {
    _CSKH_The_NapTienService = CSKH_The_NapTienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

