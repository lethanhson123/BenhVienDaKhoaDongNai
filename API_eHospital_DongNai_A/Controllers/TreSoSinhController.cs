namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TreSoSinhController : BaseController<TreSoSinh, ITreSoSinhService>
    {
    private readonly ITreSoSinhService _TreSoSinhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TreSoSinhController(ITreSoSinhService TreSoSinhService, IWebHostEnvironment WebHostEnvironment) : base(TreSoSinhService, WebHostEnvironment)
    {
    _TreSoSinhService = TreSoSinhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

