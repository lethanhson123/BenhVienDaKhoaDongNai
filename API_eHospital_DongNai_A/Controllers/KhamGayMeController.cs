namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamGayMeController : BaseController<KhamGayMe, IKhamGayMeService>
    {
    private readonly IKhamGayMeService _KhamGayMeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamGayMeController(IKhamGayMeService KhamGayMeService, IWebHostEnvironment WebHostEnvironment) : base(KhamGayMeService, WebHostEnvironment)
    {
    _KhamGayMeService = KhamGayMeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

