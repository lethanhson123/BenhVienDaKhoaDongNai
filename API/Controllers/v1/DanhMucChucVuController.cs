namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucChucVuController : BaseController<DanhMucChucVu, IDanhMucChucVuService>
    {
    private readonly IDanhMucChucVuService _DanhMucChucVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucChucVuController(IDanhMucChucVuService DanhMucChucVuService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucChucVuService, WebHostEnvironment)
    {
    _DanhMucChucVuService = DanhMucChucVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

