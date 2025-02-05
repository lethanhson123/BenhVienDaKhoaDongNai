namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NGHIPHEPController : BaseController<NS_NGHIPHEP, INS_NGHIPHEPService>
    {
    private readonly INS_NGHIPHEPService _NS_NGHIPHEPService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NGHIPHEPController(INS_NGHIPHEPService NS_NGHIPHEPService, IWebHostEnvironment WebHostEnvironment) : base(NS_NGHIPHEPService, WebHostEnvironment)
    {
    _NS_NGHIPHEPService = NS_NGHIPHEPService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

