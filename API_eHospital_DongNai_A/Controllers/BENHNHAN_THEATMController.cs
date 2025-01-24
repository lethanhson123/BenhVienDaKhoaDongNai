namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BENHNHAN_THEATMController : BaseController<BENHNHAN_THEATM, IBENHNHAN_THEATMService>
    {
    private readonly IBENHNHAN_THEATMService _BENHNHAN_THEATMService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BENHNHAN_THEATMController(IBENHNHAN_THEATMService BENHNHAN_THEATMService, IWebHostEnvironment WebHostEnvironment) : base(BENHNHAN_THEATMService, WebHostEnvironment)
    {
    _BENHNHAN_THEATMService = BENHNHAN_THEATMService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

