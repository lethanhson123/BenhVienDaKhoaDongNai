namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucTinhThanhToaDoController : BaseController<DanhMucTinhThanhToaDo, IDanhMucTinhThanhToaDoService>
    {
    private readonly IDanhMucTinhThanhToaDoService _DanhMucTinhThanhToaDoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucTinhThanhToaDoController(IDanhMucTinhThanhToaDoService DanhMucTinhThanhToaDoService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucTinhThanhToaDoService, WebHostEnvironment)
    {
    _DanhMucTinhThanhToaDoService = DanhMucTinhThanhToaDoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

