namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocKyTonKhoController : BaseController<DuocKyTonKho, IDuocKyTonKhoService>
    {
    private readonly IDuocKyTonKhoService _DuocKyTonKhoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocKyTonKhoController(IDuocKyTonKhoService DuocKyTonKhoService, IWebHostEnvironment WebHostEnvironment) : base(DuocKyTonKhoService, WebHostEnvironment)
    {
    _DuocKyTonKhoService = DuocKyTonKhoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

