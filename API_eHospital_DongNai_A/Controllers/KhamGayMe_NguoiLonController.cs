namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamGayMe_NguoiLonController : BaseController<KhamGayMe_NguoiLon, IKhamGayMe_NguoiLonService>
    {
    private readonly IKhamGayMe_NguoiLonService _KhamGayMe_NguoiLonService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamGayMe_NguoiLonController(IKhamGayMe_NguoiLonService KhamGayMe_NguoiLonService, IWebHostEnvironment WebHostEnvironment) : base(KhamGayMe_NguoiLonService, WebHostEnvironment)
    {
    _KhamGayMe_NguoiLonService = KhamGayMe_NguoiLonService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

