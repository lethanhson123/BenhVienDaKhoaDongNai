namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_ModifySource_ClientController : BaseController<Sys_ModifySource_Client, ISys_ModifySource_ClientService>
    {
    private readonly ISys_ModifySource_ClientService _Sys_ModifySource_ClientService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_ModifySource_ClientController(ISys_ModifySource_ClientService Sys_ModifySource_ClientService, IWebHostEnvironment WebHostEnvironment) : base(Sys_ModifySource_ClientService, WebHostEnvironment)
    {
    _Sys_ModifySource_ClientService = Sys_ModifySource_ClientService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

