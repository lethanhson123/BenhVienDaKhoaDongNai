namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_PHEPNAMController : BaseController<NS_PHEPNAM, INS_PHEPNAMService>
    {
    private readonly INS_PHEPNAMService _NS_PHEPNAMService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_PHEPNAMController(INS_PHEPNAMService NS_PHEPNAMService, IWebHostEnvironment WebHostEnvironment) : base(NS_PHEPNAMService, WebHostEnvironment)
    {
    _NS_PHEPNAMService = NS_PHEPNAMService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

