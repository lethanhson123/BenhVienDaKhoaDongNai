namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_OperatorsController : BaseController<Sys_Operators, ISys_OperatorsService>
    {
    private readonly ISys_OperatorsService _Sys_OperatorsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_OperatorsController(ISys_OperatorsService Sys_OperatorsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_OperatorsService, WebHostEnvironment)
    {
    _Sys_OperatorsService = Sys_OperatorsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

