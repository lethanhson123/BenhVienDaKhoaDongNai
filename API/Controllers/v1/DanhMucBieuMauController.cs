namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucBieuMauController : BaseController<DanhMucBieuMau, IDanhMucBieuMauService>
    {
    private readonly IDanhMucBieuMauService _DanhMucBieuMauService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucBieuMauController(IDanhMucBieuMauService DanhMucBieuMauService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucBieuMauService, WebHostEnvironment)
    {
    _DanhMucBieuMauService = DanhMucBieuMauService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

