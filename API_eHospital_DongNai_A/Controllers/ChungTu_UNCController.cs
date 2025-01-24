namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTu_UNCController : BaseController<ChungTu_UNC, IChungTu_UNCService>
    {
    private readonly IChungTu_UNCService _ChungTu_UNCService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChungTu_UNCController(IChungTu_UNCService ChungTu_UNCService, IWebHostEnvironment WebHostEnvironment) : base(ChungTu_UNCService, WebHostEnvironment)
    {
    _ChungTu_UNCService = ChungTu_UNCService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

