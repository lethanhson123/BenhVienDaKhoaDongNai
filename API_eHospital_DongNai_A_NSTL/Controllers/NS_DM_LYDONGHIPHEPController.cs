namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_LYDONGHIPHEPController : BaseController<NS_DM_LYDONGHIPHEP, INS_DM_LYDONGHIPHEPService>
    {
    private readonly INS_DM_LYDONGHIPHEPService _NS_DM_LYDONGHIPHEPService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_LYDONGHIPHEPController(INS_DM_LYDONGHIPHEPService NS_DM_LYDONGHIPHEPService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_LYDONGHIPHEPService, WebHostEnvironment)
    {
    _NS_DM_LYDONGHIPHEPService = NS_DM_LYDONGHIPHEPService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

