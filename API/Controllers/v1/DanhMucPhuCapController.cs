namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucPhuCapController : BaseController<DanhMucPhuCap, IDanhMucPhuCapService>
    {
    private readonly IDanhMucPhuCapService _DanhMucPhuCapService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucPhuCapController(IDanhMucPhuCapService DanhMucPhuCapService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucPhuCapService, WebHostEnvironment)
    {
    _DanhMucPhuCapService = DanhMucPhuCapService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

