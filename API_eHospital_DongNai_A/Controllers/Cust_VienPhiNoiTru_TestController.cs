namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cust_VienPhiNoiTru_TestController : BaseController<Cust_VienPhiNoiTru_Test, ICust_VienPhiNoiTru_TestService>
    {
    private readonly ICust_VienPhiNoiTru_TestService _Cust_VienPhiNoiTru_TestService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cust_VienPhiNoiTru_TestController(ICust_VienPhiNoiTru_TestService Cust_VienPhiNoiTru_TestService, IWebHostEnvironment WebHostEnvironment) : base(Cust_VienPhiNoiTru_TestService, WebHostEnvironment)
    {
    _Cust_VienPhiNoiTru_TestService = Cust_VienPhiNoiTru_TestService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

