namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_SearchDefinitionsController : BaseController<Sys_SearchDefinitions, ISys_SearchDefinitionsService>
    {
    private readonly ISys_SearchDefinitionsService _Sys_SearchDefinitionsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_SearchDefinitionsController(ISys_SearchDefinitionsService Sys_SearchDefinitionsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_SearchDefinitionsService, WebHostEnvironment)
    {
    _Sys_SearchDefinitionsService = Sys_SearchDefinitionsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

