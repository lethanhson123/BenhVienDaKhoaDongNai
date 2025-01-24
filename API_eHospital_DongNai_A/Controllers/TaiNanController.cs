namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TaiNanController : BaseController<TaiNan, ITaiNanService>
    {
    private readonly ITaiNanService _TaiNanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TaiNanController(ITaiNanService TaiNanService, IWebHostEnvironment WebHostEnvironment) : base(TaiNanService, WebHostEnvironment)
    {
    _TaiNanService = TaiNanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

