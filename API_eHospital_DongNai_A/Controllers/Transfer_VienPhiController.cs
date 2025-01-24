namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Transfer_VienPhiController : BaseController<Transfer_VienPhi, ITransfer_VienPhiService>
    {
    private readonly ITransfer_VienPhiService _Transfer_VienPhiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Transfer_VienPhiController(ITransfer_VienPhiService Transfer_VienPhiService, IWebHostEnvironment WebHostEnvironment) : base(Transfer_VienPhiService, WebHostEnvironment)
    {
    _Transfer_VienPhiService = Transfer_VienPhiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

