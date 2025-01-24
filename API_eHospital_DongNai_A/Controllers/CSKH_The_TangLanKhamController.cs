namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_TangLanKhamController : BaseController<CSKH_The_TangLanKham, ICSKH_The_TangLanKhamService>
    {
    private readonly ICSKH_The_TangLanKhamService _CSKH_The_TangLanKhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_TangLanKhamController(ICSKH_The_TangLanKhamService CSKH_The_TangLanKhamService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_TangLanKhamService, WebHostEnvironment)
    {
    _CSKH_The_TangLanKhamService = CSKH_The_TangLanKhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

