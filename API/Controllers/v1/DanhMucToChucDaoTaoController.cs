namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucToChucDaoTaoController : BaseController<DanhMucToChucDaoTao, IDanhMucToChucDaoTaoService>
    {
    private readonly IDanhMucToChucDaoTaoService _DanhMucToChucDaoTaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DanhMucToChucDaoTaoController(IDanhMucToChucDaoTaoService DanhMucToChucDaoTaoService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucToChucDaoTaoService, WebHostEnvironment)
    {
    _DanhMucToChucDaoTaoService = DanhMucToChucDaoTaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

