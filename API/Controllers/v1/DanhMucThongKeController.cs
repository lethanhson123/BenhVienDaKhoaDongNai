namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucThongKeController : BaseController<DanhMucThongKe, IDanhMucThongKeService>
    {
    private readonly IDanhMucThongKeService _DanhMucThongKeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucThongKeController(IDanhMucThongKeService DanhMucThongKeService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucThongKeService, WebHostEnvironment)
    {
    _DanhMucThongKeService = DanhMucThongKeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

