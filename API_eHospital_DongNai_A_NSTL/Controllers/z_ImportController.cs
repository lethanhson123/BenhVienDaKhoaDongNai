namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class z_ImportController : BaseController<z_Import, Iz_ImportService>
    {
    private readonly Iz_ImportService _z_ImportService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public z_ImportController(Iz_ImportService z_ImportService, IWebHostEnvironment WebHostEnvironment) : base(z_ImportService, WebHostEnvironment)
    {
    _z_ImportService = z_ImportService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

