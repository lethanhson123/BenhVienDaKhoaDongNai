namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cust_Backup_BsCCHNController : BaseController<Cust_Backup_BsCCHN, ICust_Backup_BsCCHNService>
    {
    private readonly ICust_Backup_BsCCHNService _Cust_Backup_BsCCHNService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cust_Backup_BsCCHNController(ICust_Backup_BsCCHNService Cust_Backup_BsCCHNService, IWebHostEnvironment WebHostEnvironment) : base(Cust_Backup_BsCCHNService, WebHostEnvironment)
    {
    _Cust_Backup_BsCCHNService = Cust_Backup_BsCCHNService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

