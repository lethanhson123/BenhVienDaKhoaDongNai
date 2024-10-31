namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnQuyetDinhController : BaseController<DuAnQuyetDinh, IDuAnQuyetDinhService>
    {
    private readonly IDuAnQuyetDinhService _DuAnQuyetDinhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuAnQuyetDinhController(IDuAnQuyetDinhService DuAnQuyetDinhService, IWebHostEnvironment WebHostEnvironment) : base(DuAnQuyetDinhService, WebHostEnvironment)
    {
    _DuAnQuyetDinhService = DuAnQuyetDinhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

