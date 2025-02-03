namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_HistoryDefinesController : BaseController<Sys_HistoryDefines, ISys_HistoryDefinesService>
    {
    private readonly ISys_HistoryDefinesService _Sys_HistoryDefinesService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_HistoryDefinesController(ISys_HistoryDefinesService Sys_HistoryDefinesService, IWebHostEnvironment WebHostEnvironment) : base(Sys_HistoryDefinesService, WebHostEnvironment)
    {
    _Sys_HistoryDefinesService = Sys_HistoryDefinesService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

