namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TomTatHoSoBenhAnController : BaseController<TomTatHoSoBenhAn, ITomTatHoSoBenhAnService>
    {
    private readonly ITomTatHoSoBenhAnService _TomTatHoSoBenhAnService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TomTatHoSoBenhAnController(ITomTatHoSoBenhAnService TomTatHoSoBenhAnService, IWebHostEnvironment WebHostEnvironment) : base(TomTatHoSoBenhAnService, WebHostEnvironment)
    {
    _TomTatHoSoBenhAnService = TomTatHoSoBenhAnService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

