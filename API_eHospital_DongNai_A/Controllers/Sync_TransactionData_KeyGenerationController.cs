namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sync_TransactionData_KeyGenerationController : BaseController<Sync_TransactionData_KeyGeneration, ISync_TransactionData_KeyGenerationService>
    {
    private readonly ISync_TransactionData_KeyGenerationService _Sync_TransactionData_KeyGenerationService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sync_TransactionData_KeyGenerationController(ISync_TransactionData_KeyGenerationService Sync_TransactionData_KeyGenerationService, IWebHostEnvironment WebHostEnvironment) : base(Sync_TransactionData_KeyGenerationService, WebHostEnvironment)
    {
    _Sync_TransactionData_KeyGenerationService = Sync_TransactionData_KeyGenerationService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

