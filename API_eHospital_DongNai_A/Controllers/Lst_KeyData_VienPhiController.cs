namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_VienPhiController : BaseController<Lst_KeyData_VienPhi, ILst_KeyData_VienPhiService>
    {
    private readonly ILst_KeyData_VienPhiService _Lst_KeyData_VienPhiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_VienPhiController(ILst_KeyData_VienPhiService Lst_KeyData_VienPhiService, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_VienPhiService, WebHostEnvironment)
    {
    _Lst_KeyData_VienPhiService = Lst_KeyData_VienPhiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

