namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ManHinhThongBaoController : BaseController<ManHinhThongBao, IManHinhThongBaoService>
    {
    private readonly IManHinhThongBaoService _ManHinhThongBaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ManHinhThongBaoController(IManHinhThongBaoService ManHinhThongBaoService, IWebHostEnvironment WebHostEnvironment) : base(ManHinhThongBaoService, WebHostEnvironment)
    {
    _ManHinhThongBaoService = ManHinhThongBaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

