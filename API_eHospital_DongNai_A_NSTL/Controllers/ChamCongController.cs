namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChamCongController : BaseController<ChamCong, IChamCongService>
    {
    private readonly IChamCongService _ChamCongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChamCongController(IChamCongService ChamCongService, IWebHostEnvironment WebHostEnvironment) : base(ChamCongService, WebHostEnvironment)
    {
    _ChamCongService = ChamCongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

