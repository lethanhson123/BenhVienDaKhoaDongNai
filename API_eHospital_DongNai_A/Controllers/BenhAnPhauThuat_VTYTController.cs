namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnPhauThuat_VTYTController : BaseController<BenhAnPhauThuat_VTYT, IBenhAnPhauThuat_VTYTService>
    {
    private readonly IBenhAnPhauThuat_VTYTService _BenhAnPhauThuat_VTYTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnPhauThuat_VTYTController(IBenhAnPhauThuat_VTYTService BenhAnPhauThuat_VTYTService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnPhauThuat_VTYTService, WebHostEnvironment)
    {
    _BenhAnPhauThuat_VTYTService = BenhAnPhauThuat_VTYTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

