namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuSoLoNhapController : BaseController<ChungTuSoLoNhap, IChungTuSoLoNhapService>
    {
    private readonly IChungTuSoLoNhapService _ChungTuSoLoNhapService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTuSoLoNhapController(IChungTuSoLoNhapService ChungTuSoLoNhapService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuSoLoNhapService, WebHostEnvironment)
    {
    _ChungTuSoLoNhapService = ChungTuSoLoNhapService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

