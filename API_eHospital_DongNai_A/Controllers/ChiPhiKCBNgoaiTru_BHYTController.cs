namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChiPhiKCBNgoaiTru_BHYTController : BaseController<ChiPhiKCBNgoaiTru_BHYT, IChiPhiKCBNgoaiTru_BHYTService>
    {
    private readonly IChiPhiKCBNgoaiTru_BHYTService _ChiPhiKCBNgoaiTru_BHYTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChiPhiKCBNgoaiTru_BHYTController(IChiPhiKCBNgoaiTru_BHYTService ChiPhiKCBNgoaiTru_BHYTService, IWebHostEnvironment WebHostEnvironment) : base(ChiPhiKCBNgoaiTru_BHYTService, WebHostEnvironment)
    {
    _ChiPhiKCBNgoaiTru_BHYTService = ChiPhiKCBNgoaiTru_BHYTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

