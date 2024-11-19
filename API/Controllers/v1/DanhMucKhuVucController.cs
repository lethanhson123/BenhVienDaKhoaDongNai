namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucKhuVucController : BaseController<DanhMucKhuVuc, IDanhMucKhuVucService>
    {
    private readonly IDanhMucKhuVucService _DanhMucKhuVucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucKhuVucController(IDanhMucKhuVucService DanhMucKhuVucService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucKhuVucService, WebHostEnvironment)
    {
    _DanhMucKhuVucService = DanhMucKhuVucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

