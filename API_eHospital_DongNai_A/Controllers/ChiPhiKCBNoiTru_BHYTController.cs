namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChiPhiKCBNoiTru_BHYTController : BaseController<ChiPhiKCBNoiTru_BHYT, IChiPhiKCBNoiTru_BHYTService>
    {
    private readonly IChiPhiKCBNoiTru_BHYTService _ChiPhiKCBNoiTru_BHYTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChiPhiKCBNoiTru_BHYTController(IChiPhiKCBNoiTru_BHYTService ChiPhiKCBNoiTru_BHYTService, IWebHostEnvironment WebHostEnvironment) : base(ChiPhiKCBNoiTru_BHYTService, WebHostEnvironment)
    {
    _ChiPhiKCBNoiTru_BHYTService = ChiPhiKCBNoiTru_BHYTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

