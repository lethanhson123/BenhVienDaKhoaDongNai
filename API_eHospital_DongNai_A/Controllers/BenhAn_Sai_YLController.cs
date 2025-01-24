namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_Sai_YLController : BaseController<BenhAn_Sai_YL, IBenhAn_Sai_YLService>
    {
    private readonly IBenhAn_Sai_YLService _BenhAn_Sai_YLService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_Sai_YLController(IBenhAn_Sai_YLService BenhAn_Sai_YLService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_Sai_YLService, WebHostEnvironment)
    {
    _BenhAn_Sai_YLService = BenhAn_Sai_YLService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

