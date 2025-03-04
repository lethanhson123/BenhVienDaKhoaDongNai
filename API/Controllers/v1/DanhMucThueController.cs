namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucThueController : BaseController<DanhMucThue, IDanhMucThueService>
    {
    private readonly IDanhMucThueService _DanhMucThueService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucThueController(IDanhMucThueService DanhMucThueService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucThueService, WebHostEnvironment)
    {
    _DanhMucThueService = DanhMucThueService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

