namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_ModifySource_ComputerController : BaseController<Sys_ModifySource_Computer, ISys_ModifySource_ComputerService>
    {
    private readonly ISys_ModifySource_ComputerService _Sys_ModifySource_ComputerService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_ModifySource_ComputerController(ISys_ModifySource_ComputerService Sys_ModifySource_ComputerService, IWebHostEnvironment WebHostEnvironment) : base(Sys_ModifySource_ComputerService, WebHostEnvironment)
    {
    _Sys_ModifySource_ComputerService = Sys_ModifySource_ComputerService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

