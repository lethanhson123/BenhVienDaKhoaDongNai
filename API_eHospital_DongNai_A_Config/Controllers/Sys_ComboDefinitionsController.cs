namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_ComboDefinitionsController : BaseController<Sys_ComboDefinitions, ISys_ComboDefinitionsService>
    {
    private readonly ISys_ComboDefinitionsService _Sys_ComboDefinitionsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_ComboDefinitionsController(ISys_ComboDefinitionsService Sys_ComboDefinitionsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_ComboDefinitionsService, WebHostEnvironment)
    {
    _Sys_ComboDefinitionsService = Sys_ComboDefinitionsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

