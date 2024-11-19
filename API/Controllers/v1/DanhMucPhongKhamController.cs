namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucPhongKhamController : BaseController<DanhMucPhongKham, IDanhMucPhongKhamService>
    {
    private readonly IDanhMucPhongKhamService _DanhMucPhongKhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucPhongKhamController(IDanhMucPhongKhamService DanhMucPhongKhamService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucPhongKhamService, WebHostEnvironment)
    {
    _DanhMucPhongKhamService = DanhMucPhongKhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

