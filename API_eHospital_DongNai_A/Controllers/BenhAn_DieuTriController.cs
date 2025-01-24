namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_DieuTriController : BaseController<BenhAn_DieuTri, IBenhAn_DieuTriService>
    {
    private readonly IBenhAn_DieuTriService _BenhAn_DieuTriService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_DieuTriController(IBenhAn_DieuTriService BenhAn_DieuTriService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_DieuTriService, WebHostEnvironment)
    {
    _BenhAn_DieuTriService = BenhAn_DieuTriService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

