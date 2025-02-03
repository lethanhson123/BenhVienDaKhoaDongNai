namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_ConfigsController : BaseController<Sys_Configs, ISys_ConfigsService>
    {
    private readonly ISys_ConfigsService _Sys_ConfigsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_ConfigsController(ISys_ConfigsService Sys_ConfigsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_ConfigsService, WebHostEnvironment)
    {
    _Sys_ConfigsService = Sys_ConfigsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

