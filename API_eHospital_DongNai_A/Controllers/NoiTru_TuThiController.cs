namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_TuThiController : BaseController<NoiTru_TuThi, INoiTru_TuThiService>
    {
    private readonly INoiTru_TuThiService _NoiTru_TuThiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NoiTru_TuThiController(INoiTru_TuThiService NoiTru_TuThiService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_TuThiService, WebHostEnvironment)
    {
    _NoiTru_TuThiService = NoiTru_TuThiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

