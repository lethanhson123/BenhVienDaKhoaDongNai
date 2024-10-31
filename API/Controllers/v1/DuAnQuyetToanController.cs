namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnQuyetToanController : BaseController<DuAnQuyetToan, IDuAnQuyetToanService>
    {
    private readonly IDuAnQuyetToanService _DuAnQuyetToanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuAnQuyetToanController(IDuAnQuyetToanService DuAnQuyetToanService, IWebHostEnvironment WebHostEnvironment) : base(DuAnQuyetToanService, WebHostEnvironment)
    {
    _DuAnQuyetToanService = DuAnQuyetToanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

