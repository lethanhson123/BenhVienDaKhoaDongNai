namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TonKhoController : BaseController<TonKho, ITonKhoService>
    {
    private readonly ITonKhoService _TonKhoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TonKhoController(ITonKhoService TonKhoService, IWebHostEnvironment WebHostEnvironment) : base(TonKhoService, WebHostEnvironment)
    {
    _TonKhoService = TonKhoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

