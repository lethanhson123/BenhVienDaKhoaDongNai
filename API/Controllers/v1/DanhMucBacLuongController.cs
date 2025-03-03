namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucBacLuongController : BaseController<DanhMucBacLuong, IDanhMucBacLuongService>
    {
    private readonly IDanhMucBacLuongService _DanhMucBacLuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucBacLuongController(IDanhMucBacLuongService DanhMucBacLuongService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucBacLuongService, WebHostEnvironment)
    {
    _DanhMucBacLuongService = DanhMucBacLuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

