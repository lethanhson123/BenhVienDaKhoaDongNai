namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LabIQC_NewController : BaseController<LabIQC_New, ILabIQC_NewService>
    {
    private readonly ILabIQC_NewService _LabIQC_NewService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LabIQC_NewController(ILabIQC_NewService LabIQC_NewService, IWebHostEnvironment WebHostEnvironment) : base(LabIQC_NewService, WebHostEnvironment)
    {
    _LabIQC_NewService = LabIQC_NewService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

