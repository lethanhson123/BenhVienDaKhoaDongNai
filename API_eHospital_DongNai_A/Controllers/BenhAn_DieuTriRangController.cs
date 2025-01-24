namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_DieuTriRangController : BaseController<BenhAn_DieuTriRang, IBenhAn_DieuTriRangService>
    {
    private readonly IBenhAn_DieuTriRangService _BenhAn_DieuTriRangService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_DieuTriRangController(IBenhAn_DieuTriRangService BenhAn_DieuTriRangService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_DieuTriRangService, WebHostEnvironment)
    {
    _BenhAn_DieuTriRangService = BenhAn_DieuTriRangService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

