namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ToChucController : BaseController<ToChuc, IToChucService>
    {
    private readonly IToChucService _ToChucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ToChucController(IToChucService ToChucService, IWebHostEnvironment WebHostEnvironment) : base(ToChucService, WebHostEnvironment)
    {
    _ToChucService = ToChucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

