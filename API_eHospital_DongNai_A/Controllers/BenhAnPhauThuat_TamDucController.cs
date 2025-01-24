namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnPhauThuat_TamDucController : BaseController<BenhAnPhauThuat_TamDuc, IBenhAnPhauThuat_TamDucService>
    {
    private readonly IBenhAnPhauThuat_TamDucService _BenhAnPhauThuat_TamDucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnPhauThuat_TamDucController(IBenhAnPhauThuat_TamDucService BenhAnPhauThuat_TamDucService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnPhauThuat_TamDucService, WebHostEnvironment)
    {
    _BenhAnPhauThuat_TamDucService = BenhAnPhauThuat_TamDucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

