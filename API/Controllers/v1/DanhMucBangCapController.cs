namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucBangCapController : BaseController<DanhMucBangCap, IDanhMucBangCapService>
    {
    private readonly IDanhMucBangCapService _DanhMucBangCapService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucBangCapController(IDanhMucBangCapService DanhMucBangCapService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucBangCapService, WebHostEnvironment)
    {
    _DanhMucBangCapService = DanhMucBangCapService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

