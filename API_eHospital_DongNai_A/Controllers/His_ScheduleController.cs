namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class His_ScheduleController : BaseController<His_Schedule, IHis_ScheduleService>
    {
    private readonly IHis_ScheduleService _His_ScheduleService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public His_ScheduleController(IHis_ScheduleService His_ScheduleService, IWebHostEnvironment WebHostEnvironment) : base(His_ScheduleService, WebHostEnvironment)
    {
    _His_ScheduleService = His_ScheduleService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

