namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuatController : BaseController<BenhAnTongQuat, IBenhAnTongQuatService>
    {
    private readonly IBenhAnTongQuatService _BenhAnTongQuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuatController(IBenhAnTongQuatService BenhAnTongQuatService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuatService, WebHostEnvironment)
    {
    _BenhAnTongQuatService = BenhAnTongQuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

