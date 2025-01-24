namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_TangTienController : BaseController<CSKH_The_TangTien, ICSKH_The_TangTienService>
    {
    private readonly ICSKH_The_TangTienService _CSKH_The_TangTienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_TangTienController(ICSKH_The_TangTienService CSKH_The_TangTienService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_TangTienService, WebHostEnvironment)
    {
    _CSKH_The_TangTienService = CSKH_The_TangTienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

