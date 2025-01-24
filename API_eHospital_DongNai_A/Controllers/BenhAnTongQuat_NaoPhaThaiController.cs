namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_NaoPhaThaiController : BaseController<BenhAnTongQuat_NaoPhaThai, IBenhAnTongQuat_NaoPhaThaiService>
    {
    private readonly IBenhAnTongQuat_NaoPhaThaiService _BenhAnTongQuat_NaoPhaThaiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_NaoPhaThaiController(IBenhAnTongQuat_NaoPhaThaiService BenhAnTongQuat_NaoPhaThaiService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_NaoPhaThaiService, WebHostEnvironment)
    {
    _BenhAnTongQuat_NaoPhaThaiService = BenhAnTongQuat_NaoPhaThaiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

