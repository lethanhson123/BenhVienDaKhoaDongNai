namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_SYS_HANGSOController : BaseController<NS_SYS_HANGSO, INS_SYS_HANGSOService>
    {
    private readonly INS_SYS_HANGSOService _NS_SYS_HANGSOService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_SYS_HANGSOController(INS_SYS_HANGSOService NS_SYS_HANGSOService, IWebHostEnvironment WebHostEnvironment) : base(NS_SYS_HANGSOService, WebHostEnvironment)
    {
    _NS_SYS_HANGSOService = NS_SYS_HANGSOService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

