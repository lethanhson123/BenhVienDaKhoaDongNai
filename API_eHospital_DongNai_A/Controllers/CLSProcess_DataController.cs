namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSProcess_DataController : BaseController<CLSProcess_Data, ICLSProcess_DataService>
    {
    private readonly ICLSProcess_DataService _CLSProcess_DataService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSProcess_DataController(ICLSProcess_DataService CLSProcess_DataService, IWebHostEnvironment WebHostEnvironment) : base(CLSProcess_DataService, WebHostEnvironment)
    {
    _CLSProcess_DataService = CLSProcess_DataService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

