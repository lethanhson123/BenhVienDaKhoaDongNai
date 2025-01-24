namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lab_SIDStatusController : BaseController<Lab_SIDStatus, ILab_SIDStatusService>
    {
    private readonly ILab_SIDStatusService _Lab_SIDStatusService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lab_SIDStatusController(ILab_SIDStatusService Lab_SIDStatusService, IWebHostEnvironment WebHostEnvironment) : base(Lab_SIDStatusService, WebHostEnvironment)
    {
    _Lab_SIDStatusService = Lab_SIDStatusService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

