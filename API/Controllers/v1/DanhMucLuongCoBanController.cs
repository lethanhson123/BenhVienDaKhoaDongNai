namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucLuongCoBanController : BaseController<DanhMucLuongCoBan, IDanhMucLuongCoBanService>
    {
    private readonly IDanhMucLuongCoBanService _DanhMucLuongCoBanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucLuongCoBanController(IDanhMucLuongCoBanService DanhMucLuongCoBanService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucLuongCoBanService, WebHostEnvironment)
    {
    _DanhMucLuongCoBanService = DanhMucLuongCoBanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

