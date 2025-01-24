namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_UserWorkingController : BaseController<Sys_UserWorking, ISys_UserWorkingService>
    {
    private readonly ISys_UserWorkingService _Sys_UserWorkingService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_UserWorkingController(ISys_UserWorkingService Sys_UserWorkingService, IWebHostEnvironment WebHostEnvironment) : base(Sys_UserWorkingService, WebHostEnvironment)
    {
    _Sys_UserWorkingService = Sys_UserWorkingService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

