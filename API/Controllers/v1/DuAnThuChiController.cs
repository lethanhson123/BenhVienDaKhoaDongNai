namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuAnThuChiController : BaseController<DuAnThuChi, IDuAnThuChiService>
    {
    private readonly IDuAnThuChiService _DuAnThuChiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuAnThuChiController(IDuAnThuChiService DuAnThuChiService, IWebHostEnvironment WebHostEnvironment) : base(DuAnThuChiService, WebHostEnvironment)
    {
    _DuAnThuChiService = DuAnThuChiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

