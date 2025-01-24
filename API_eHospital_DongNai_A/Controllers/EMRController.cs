namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class EMRController : BaseController<EMR, IEMRService>
    {
    private readonly IEMRService _EMRService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public EMRController(IEMRService EMRService, IWebHostEnvironment WebHostEnvironment) : base(EMRService, WebHostEnvironment)
    {
    _EMRService = EMRService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

