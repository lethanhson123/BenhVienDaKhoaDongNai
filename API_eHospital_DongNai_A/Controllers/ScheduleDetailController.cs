namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ScheduleDetailController : BaseController<ScheduleDetail, IScheduleDetailService>
    {
    private readonly IScheduleDetailService _ScheduleDetailService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ScheduleDetailController(IScheduleDetailService ScheduleDetailService, IWebHostEnvironment WebHostEnvironment) : base(ScheduleDetailService, WebHostEnvironment)
    {
    _ScheduleDetailService = ScheduleDetailService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

