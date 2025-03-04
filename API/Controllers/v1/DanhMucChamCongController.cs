namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucChamCongController : BaseController<DanhMucChamCong, IDanhMucChamCongService>
    {
    private readonly IDanhMucChamCongService _DanhMucChamCongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucChamCongController(IDanhMucChamCongService DanhMucChamCongService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucChamCongService, WebHostEnvironment)
    {
    _DanhMucChamCongService = DanhMucChamCongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

