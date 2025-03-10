namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongKeChiTietController : BaseController<ThongKeChiTiet, IThongKeChiTietService>
    {
    private readonly IThongKeChiTietService _ThongKeChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThongKeChiTietController(IThongKeChiTietService ThongKeChiTietService, IWebHostEnvironment WebHostEnvironment) : base(ThongKeChiTietService, WebHostEnvironment)
    {
    _ThongKeChiTietService = ThongKeChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

