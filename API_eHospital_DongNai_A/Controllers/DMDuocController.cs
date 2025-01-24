namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DMDuocController : BaseController<DMDuoc, IDMDuocService>
    {
    private readonly IDMDuocService _DMDuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DMDuocController(IDMDuocService DMDuocService, IWebHostEnvironment WebHostEnvironment) : base(DMDuocService, WebHostEnvironment)
    {
    _DMDuocService = DMDuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

