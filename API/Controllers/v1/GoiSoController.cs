namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoController : BaseController<GoiSo, IGoiSoService>
    {
    private readonly IGoiSoService _GoiSoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GoiSoController(IGoiSoService GoiSoService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoService, WebHostEnvironment)
    {
    _GoiSoService = GoiSoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

