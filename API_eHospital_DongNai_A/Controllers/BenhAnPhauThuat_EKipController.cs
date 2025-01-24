namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnPhauThuat_EKipController : BaseController<BenhAnPhauThuat_EKip, IBenhAnPhauThuat_EKipService>
    {
    private readonly IBenhAnPhauThuat_EKipService _BenhAnPhauThuat_EKipService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnPhauThuat_EKipController(IBenhAnPhauThuat_EKipService BenhAnPhauThuat_EKipService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnPhauThuat_EKipService, WebHostEnvironment)
    {
    _BenhAnPhauThuat_EKipService = BenhAnPhauThuat_EKipService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

