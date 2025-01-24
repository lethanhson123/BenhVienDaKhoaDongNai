namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamGayMe_TreEmController : BaseController<KhamGayMe_TreEm, IKhamGayMe_TreEmService>
    {
    private readonly IKhamGayMe_TreEmService _KhamGayMe_TreEmService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamGayMe_TreEmController(IKhamGayMe_TreEmService KhamGayMe_TreEmService, IWebHostEnvironment WebHostEnvironment) : base(KhamGayMe_TreEmService, WebHostEnvironment)
    {
    _KhamGayMe_TreEmService = KhamGayMe_TreEmService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

