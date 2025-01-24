namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonKhoController : BaseController<DuocTonKho, IDuocTonKhoService>
    {
    private readonly IDuocTonKhoService _DuocTonKhoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonKhoController(IDuocTonKhoService DuocTonKhoService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonKhoService, WebHostEnvironment)
    {
    _DuocTonKhoService = DuocTonKhoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

