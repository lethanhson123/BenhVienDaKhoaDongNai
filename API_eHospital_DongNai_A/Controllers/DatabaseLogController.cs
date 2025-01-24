namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DatabaseLogController : BaseController<DatabaseLog, IDatabaseLogService>
    {
    private readonly IDatabaseLogService _DatabaseLogService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DatabaseLogController(IDatabaseLogService DatabaseLogService, IWebHostEnvironment WebHostEnvironment) : base(DatabaseLogService, WebHostEnvironment)
    {
    _DatabaseLogService = DatabaseLogService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

