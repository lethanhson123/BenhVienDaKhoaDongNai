namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Cus_DoiTacController : BaseController<Cus_DoiTac, ICus_DoiTacService>
    {
    private readonly ICus_DoiTacService _Cus_DoiTacService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Cus_DoiTacController(ICus_DoiTacService Cus_DoiTacService, IWebHostEnvironment WebHostEnvironment) : base(Cus_DoiTacService, WebHostEnvironment)
    {
    _Cus_DoiTacService = Cus_DoiTacService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

