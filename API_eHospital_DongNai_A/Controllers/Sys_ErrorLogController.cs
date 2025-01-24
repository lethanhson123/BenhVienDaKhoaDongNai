namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_ErrorLogController : BaseController<Sys_ErrorLog, ISys_ErrorLogService>
    {
    private readonly ISys_ErrorLogService _Sys_ErrorLogService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_ErrorLogController(ISys_ErrorLogService Sys_ErrorLogService, IWebHostEnvironment WebHostEnvironment) : base(Sys_ErrorLogService, WebHostEnvironment)
    {
    _Sys_ErrorLogService = Sys_ErrorLogService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

