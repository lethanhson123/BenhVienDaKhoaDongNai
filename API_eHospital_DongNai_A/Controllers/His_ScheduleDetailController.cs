namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class His_ScheduleDetailController : BaseController<His_ScheduleDetail, IHis_ScheduleDetailService>
    {
    private readonly IHis_ScheduleDetailService _His_ScheduleDetailService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public His_ScheduleDetailController(IHis_ScheduleDetailService His_ScheduleDetailService, IWebHostEnvironment WebHostEnvironment) : base(His_ScheduleDetailService, WebHostEnvironment)
    {
    _His_ScheduleDetailService = His_ScheduleDetailService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

