namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucQuayDichVuController : BaseController<DanhMucQuayDichVu, IDanhMucQuayDichVuService>
    {
    private readonly IDanhMucQuayDichVuService _DanhMucQuayDichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucQuayDichVuController(IDanhMucQuayDichVuService DanhMucQuayDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucQuayDichVuService, WebHostEnvironment)
    {
    _DanhMucQuayDichVuService = DanhMucQuayDichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

