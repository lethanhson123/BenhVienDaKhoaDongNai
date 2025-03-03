namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucChuyenNganhController : BaseController<DanhMucChuyenNganh, IDanhMucChuyenNganhService>
    {
    private readonly IDanhMucChuyenNganhService _DanhMucChuyenNganhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucChuyenNganhController(IDanhMucChuyenNganhService DanhMucChuyenNganhService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucChuyenNganhService, WebHostEnvironment)
    {
    _DanhMucChuyenNganhService = DanhMucChuyenNganhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

