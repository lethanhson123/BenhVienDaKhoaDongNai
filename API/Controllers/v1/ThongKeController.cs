namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongKeController : BaseController<ThongKe, IThongKeService>
    {
    private readonly IThongKeService _ThongKeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThongKeController(IThongKeService ThongKeService, IWebHostEnvironment WebHostEnvironment) : base(ThongKeService, WebHostEnvironment)
    {
    _ThongKeService = ThongKeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

