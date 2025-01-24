namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuChiPhiController : BaseController<ChungTuChiPhi, IChungTuChiPhiService>
    {
    private readonly IChungTuChiPhiService _ChungTuChiPhiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTuChiPhiController(IChungTuChiPhiService ChungTuChiPhiService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuChiPhiService, WebHostEnvironment)
    {
    _ChungTuChiPhiService = ChungTuChiPhiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

