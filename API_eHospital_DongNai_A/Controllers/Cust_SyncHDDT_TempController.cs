namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cust_SyncHDDT_TempController : BaseController<Cust_SyncHDDT_Temp, ICust_SyncHDDT_TempService>
    {
    private readonly ICust_SyncHDDT_TempService _Cust_SyncHDDT_TempService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cust_SyncHDDT_TempController(ICust_SyncHDDT_TempService Cust_SyncHDDT_TempService, IWebHostEnvironment WebHostEnvironment) : base(Cust_SyncHDDT_TempService, WebHostEnvironment)
    {
    _Cust_SyncHDDT_TempService = Cust_SyncHDDT_TempService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

