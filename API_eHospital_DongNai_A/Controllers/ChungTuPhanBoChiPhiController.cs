namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuPhanBoChiPhiController : BaseController<ChungTuPhanBoChiPhi, IChungTuPhanBoChiPhiService>
    {
    private readonly IChungTuPhanBoChiPhiService _ChungTuPhanBoChiPhiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTuPhanBoChiPhiController(IChungTuPhanBoChiPhiService ChungTuPhanBoChiPhiService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuPhanBoChiPhiService, WebHostEnvironment)
    {
    _ChungTuPhanBoChiPhiService = ChungTuPhanBoChiPhiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

