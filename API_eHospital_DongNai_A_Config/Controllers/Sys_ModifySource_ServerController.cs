namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_ModifySource_ServerController : BaseController<Sys_ModifySource_Server, ISys_ModifySource_ServerService>
    {
    private readonly ISys_ModifySource_ServerService _Sys_ModifySource_ServerService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_ModifySource_ServerController(ISys_ModifySource_ServerService Sys_ModifySource_ServerService, IWebHostEnvironment WebHostEnvironment) : base(Sys_ModifySource_ServerService, WebHostEnvironment)
    {
    _Sys_ModifySource_ServerService = Sys_ModifySource_ServerService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

