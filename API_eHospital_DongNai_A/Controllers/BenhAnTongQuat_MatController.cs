namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_MatController : BaseController<BenhAnTongQuat_Mat, IBenhAnTongQuat_MatService>
    {
    private readonly IBenhAnTongQuat_MatService _BenhAnTongQuat_MatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_MatController(IBenhAnTongQuat_MatService BenhAnTongQuat_MatService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_MatService, WebHostEnvironment)
    {
    _BenhAnTongQuat_MatService = BenhAnTongQuat_MatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

