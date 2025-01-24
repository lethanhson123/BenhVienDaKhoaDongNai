namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_CTNT_ChiTietController : BaseController<BenhAnTongQuat_CTNT_ChiTiet, IBenhAnTongQuat_CTNT_ChiTietService>
    {
    private readonly IBenhAnTongQuat_CTNT_ChiTietService _BenhAnTongQuat_CTNT_ChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_CTNT_ChiTietController(IBenhAnTongQuat_CTNT_ChiTietService BenhAnTongQuat_CTNT_ChiTietService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_CTNT_ChiTietService, WebHostEnvironment)
    {
    _BenhAnTongQuat_CTNT_ChiTietService = BenhAnTongQuat_CTNT_ChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

