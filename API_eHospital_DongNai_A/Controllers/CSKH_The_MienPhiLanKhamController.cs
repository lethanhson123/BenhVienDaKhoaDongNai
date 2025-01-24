namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_MienPhiLanKhamController : BaseController<CSKH_The_MienPhiLanKham, ICSKH_The_MienPhiLanKhamService>
    {
    private readonly ICSKH_The_MienPhiLanKhamService _CSKH_The_MienPhiLanKhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_MienPhiLanKhamController(ICSKH_The_MienPhiLanKhamService CSKH_The_MienPhiLanKhamService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_MienPhiLanKhamService, WebHostEnvironment)
    {
    _CSKH_The_MienPhiLanKhamService = CSKH_The_MienPhiLanKhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

