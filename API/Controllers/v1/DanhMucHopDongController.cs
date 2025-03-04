namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucHopDongController : BaseController<DanhMucHopDong, IDanhMucHopDongService>
    {
    private readonly IDanhMucHopDongService _DanhMucHopDongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucHopDongController(IDanhMucHopDongService DanhMucHopDongService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucHopDongService, WebHostEnvironment)
    {
    _DanhMucHopDongService = DanhMucHopDongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

