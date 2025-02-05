namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_FILTERController : BaseController<NS_RP_FILTER, INS_RP_FILTERService>
    {
    private readonly INS_RP_FILTERService _NS_RP_FILTERService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_FILTERController(INS_RP_FILTERService NS_RP_FILTERService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_FILTERService, WebHostEnvironment)
    {
    _NS_RP_FILTERService = NS_RP_FILTERService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

