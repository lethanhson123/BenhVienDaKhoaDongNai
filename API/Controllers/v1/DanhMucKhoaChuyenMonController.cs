namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucKhoaChuyenMonController : BaseController<DanhMucKhoaChuyenMon, IDanhMucKhoaChuyenMonService>
    {
    private readonly IDanhMucKhoaChuyenMonService _DanhMucKhoaChuyenMonService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucKhoaChuyenMonController(IDanhMucKhoaChuyenMonService DanhMucKhoaChuyenMonService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucKhoaChuyenMonService, WebHostEnvironment)
    {
    _DanhMucKhoaChuyenMonService = DanhMucKhoaChuyenMonService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

