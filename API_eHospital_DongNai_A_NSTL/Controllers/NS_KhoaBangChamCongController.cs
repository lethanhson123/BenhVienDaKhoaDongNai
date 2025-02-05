namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_KhoaBangChamCongController : BaseController<NS_KhoaBangChamCong, INS_KhoaBangChamCongService>
    {
    private readonly INS_KhoaBangChamCongService _NS_KhoaBangChamCongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_KhoaBangChamCongController(INS_KhoaBangChamCongService NS_KhoaBangChamCongService, IWebHostEnvironment WebHostEnvironment) : base(NS_KhoaBangChamCongService, WebHostEnvironment)
    {
    _NS_KhoaBangChamCongService = NS_KhoaBangChamCongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

