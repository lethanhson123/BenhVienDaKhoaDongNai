namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cust_VienPhiNoiTru_Test_2_UpdateController : BaseController<Cust_VienPhiNoiTru_Test2_Update, ICust_VienPhiNoiTru_Test2_UpdateService>
    {
    private readonly ICust_VienPhiNoiTru_Test2_UpdateService _Cust_VienPhiNoiTru_Test2_UpdateService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cust_VienPhiNoiTru_Test_2_UpdateController(ICust_VienPhiNoiTru_Test2_UpdateService Cust_VienPhiNoiTru_Test2_UpdateService, IWebHostEnvironment WebHostEnvironment) : base(Cust_VienPhiNoiTru_Test2_UpdateService, WebHostEnvironment)
    {
    _Cust_VienPhiNoiTru_Test2_UpdateService = Cust_VienPhiNoiTru_Test2_UpdateService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

