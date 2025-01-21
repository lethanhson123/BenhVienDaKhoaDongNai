namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucMauSacController : BaseController<DanhMucMauSac, IDanhMucMauSacService>
    {
    private readonly IDanhMucMauSacService _DanhMucMauSacService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucMauSacController(IDanhMucMauSacService DanhMucMauSacService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucMauSacService, WebHostEnvironment)
    {
    _DanhMucMauSacService = DanhMucMauSacService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

