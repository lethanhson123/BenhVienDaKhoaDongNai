namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cust_VienPhiNoiTru_Test_2Controller : BaseController<Cust_VienPhiNoiTru_Test2, ICust_VienPhiNoiTru_Test2Service>
    {
    private readonly ICust_VienPhiNoiTru_Test2Service _Cust_VienPhiNoiTru_Test2Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cust_VienPhiNoiTru_Test_2Controller(ICust_VienPhiNoiTru_Test2Service Cust_VienPhiNoiTru_Test2Service, IWebHostEnvironment WebHostEnvironment) : base(Cust_VienPhiNoiTru_Test2Service, WebHostEnvironment)
    {
    _Cust_VienPhiNoiTru_Test2Service = Cust_VienPhiNoiTru_Test2Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

