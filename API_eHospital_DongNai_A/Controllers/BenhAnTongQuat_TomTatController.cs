namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_TomTatController : BaseController<BenhAnTongQuat_TomTat, IBenhAnTongQuat_TomTatService>
    {
    private readonly IBenhAnTongQuat_TomTatService _BenhAnTongQuat_TomTatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_TomTatController(IBenhAnTongQuat_TomTatService BenhAnTongQuat_TomTatService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_TomTatService, WebHostEnvironment)
    {
    _BenhAnTongQuat_TomTatService = BenhAnTongQuat_TomTatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

