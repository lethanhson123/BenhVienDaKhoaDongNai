namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_FORMULARSController : BaseController<NS_RP_FORMULARS, INS_RP_FORMULARSService>
    {
    private readonly INS_RP_FORMULARSService _NS_RP_FORMULARSService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_FORMULARSController(INS_RP_FORMULARSService NS_RP_FORMULARSService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_FORMULARSService, WebHostEnvironment)
    {
    _NS_RP_FORMULARSService = NS_RP_FORMULARSService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

