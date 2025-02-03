namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_LovDefinitionsController : BaseController<Sys_LovDefinitions, ISys_LovDefinitionsService>
    {
    private readonly ISys_LovDefinitionsService _Sys_LovDefinitionsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_LovDefinitionsController(ISys_LovDefinitionsService Sys_LovDefinitionsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_LovDefinitionsService, WebHostEnvironment)
    {
    _Sys_LovDefinitionsService = Sys_LovDefinitionsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

