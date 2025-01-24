namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChayThanNhanTaoController : BaseController<ChayThanNhanTao, IChayThanNhanTaoService>
    {
    private readonly IChayThanNhanTaoService _ChayThanNhanTaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChayThanNhanTaoController(IChayThanNhanTaoService ChayThanNhanTaoService, IWebHostEnvironment WebHostEnvironment) : base(ChayThanNhanTaoService, WebHostEnvironment)
    {
    _ChayThanNhanTaoService = ChayThanNhanTaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

