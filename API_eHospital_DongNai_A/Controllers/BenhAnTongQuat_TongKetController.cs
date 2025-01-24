namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_TongKetController : BaseController<BenhAnTongQuat_TongKet, IBenhAnTongQuat_TongKetService>
    {
    private readonly IBenhAnTongQuat_TongKetService _BenhAnTongQuat_TongKetService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_TongKetController(IBenhAnTongQuat_TongKetService BenhAnTongQuat_TongKetService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_TongKetService, WebHostEnvironment)
    {
    _BenhAnTongQuat_TongKetService = BenhAnTongQuat_TongKetService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

