namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class sysdiagramsController : BaseController<sysdiagrams, IsysdiagramsService>
    {
    private readonly IsysdiagramsService _sysdiagramsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public sysdiagramsController(IsysdiagramsService sysdiagramsService, IWebHostEnvironment WebHostEnvironment) : base(sysdiagramsService, WebHostEnvironment)
    {
    _sysdiagramsService = sysdiagramsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

