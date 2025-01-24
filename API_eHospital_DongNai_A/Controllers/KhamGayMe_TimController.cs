namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamGayMe_TimController : BaseController<KhamGayMe_Tim, IKhamGayMe_TimService>
    {
    private readonly IKhamGayMe_TimService _KhamGayMe_TimService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamGayMe_TimController(IKhamGayMe_TimService KhamGayMe_TimService, IWebHostEnvironment WebHostEnvironment) : base(KhamGayMe_TimService, WebHostEnvironment)
    {
    _KhamGayMe_TimService = KhamGayMe_TimService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

