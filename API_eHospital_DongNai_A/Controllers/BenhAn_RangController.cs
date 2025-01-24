namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_RangController : BaseController<BenhAn_Rang, IBenhAn_RangService>
    {
    private readonly IBenhAn_RangService _BenhAn_RangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_RangController(IBenhAn_RangService BenhAn_RangService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_RangService, WebHostEnvironment)
    {
    _BenhAn_RangService = BenhAn_RangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

