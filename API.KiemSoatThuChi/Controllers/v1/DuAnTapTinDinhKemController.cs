namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnTapTinDinhKemController : BaseController<DuAnTapTinDinhKem, IDuAnTapTinDinhKemService>
    {
    private readonly IDuAnTapTinDinhKemService _DuAnTapTinDinhKemService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuAnTapTinDinhKemController(IDuAnTapTinDinhKemService DuAnTapTinDinhKemService, IWebHostEnvironment WebHostEnvironment) : base(DuAnTapTinDinhKemService, WebHostEnvironment)
    {
    _DuAnTapTinDinhKemService = DuAnTapTinDinhKemService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

