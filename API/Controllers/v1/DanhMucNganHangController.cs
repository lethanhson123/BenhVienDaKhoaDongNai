namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucNganHangController : BaseController<DanhMucNganHang, IDanhMucNganHangService>
    {
    private readonly IDanhMucNganHangService _DanhMucNganHangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucNganHangController(IDanhMucNganHangService DanhMucNganHangService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucNganHangService, WebHostEnvironment)
    {
    _DanhMucNganHangService = DanhMucNganHangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

