namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DongNai_AController : BaseController<DongNai_A, IDongNai_AService>
    {
    private readonly IDongNai_AService _DongNai_AService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DongNai_AController(IDongNai_AService DongNai_AService, IWebHostEnvironment WebHostEnvironment) : base(DongNai_AService, WebHostEnvironment)
    {
    _DongNai_AService = DongNai_AService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

