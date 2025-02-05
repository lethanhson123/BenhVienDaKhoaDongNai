namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class dtpropertiesController : BaseController<dtproperties, IdtpropertiesService>
    {
    private readonly IdtpropertiesService _dtpropertiesService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public dtpropertiesController(IdtpropertiesService dtpropertiesService, IWebHostEnvironment WebHostEnvironment) : base(dtpropertiesService, WebHostEnvironment)
    {
    _dtpropertiesService = dtpropertiesService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

