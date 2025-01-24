namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ScheduleController : BaseController<Schedule, IScheduleService>
    {
    private readonly IScheduleService _ScheduleService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ScheduleController(IScheduleService ScheduleService, IWebHostEnvironment WebHostEnvironment) : base(ScheduleService, WebHostEnvironment)
    {
    _ScheduleService = ScheduleService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

