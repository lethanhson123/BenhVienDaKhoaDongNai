namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucHinhThucThanhToanController : BaseController<DanhMucHinhThucThanhToan, IDanhMucHinhThucThanhToanService>
    {
    private readonly IDanhMucHinhThucThanhToanService _DanhMucHinhThucThanhToanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucHinhThucThanhToanController(IDanhMucHinhThucThanhToanService DanhMucHinhThucThanhToanService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucHinhThucThanhToanService, WebHostEnvironment)
    {
    _DanhMucHinhThucThanhToanService = DanhMucHinhThucThanhToanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

