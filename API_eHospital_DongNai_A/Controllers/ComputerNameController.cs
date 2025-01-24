namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ComputerNameController : BaseController<ComputerName, IComputerNameService>
    {
    private readonly IComputerNameService _ComputerNameService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ComputerNameController(IComputerNameService ComputerNameService, IWebHostEnvironment WebHostEnvironment) : base(ComputerNameService, WebHostEnvironment)
    {
    _ComputerNameService = ComputerNameService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

