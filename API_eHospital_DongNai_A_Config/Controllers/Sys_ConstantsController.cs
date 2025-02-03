namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_ConstantsController : BaseController<Sys_Constants, ISys_ConstantsService>
    {
    private readonly ISys_ConstantsService _Sys_ConstantsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_ConstantsController(ISys_ConstantsService Sys_ConstantsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_ConstantsService, WebHostEnvironment)
    {
    _Sys_ConstantsService = Sys_ConstantsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

