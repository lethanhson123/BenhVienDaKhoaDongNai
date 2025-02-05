namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DIEUCHUYENController : BaseController<NS_DIEUCHUYEN, INS_DIEUCHUYENService>
    {
    private readonly INS_DIEUCHUYENService _NS_DIEUCHUYENService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DIEUCHUYENController(INS_DIEUCHUYENService NS_DIEUCHUYENService, IWebHostEnvironment WebHostEnvironment) : base(NS_DIEUCHUYENService, WebHostEnvironment)
    {
    _NS_DIEUCHUYENService = NS_DIEUCHUYENService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

