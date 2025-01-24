namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_TruyenNhiemController : BaseController<BenhAnTongQuat_TruyenNhiem, IBenhAnTongQuat_TruyenNhiemService>
    {
    private readonly IBenhAnTongQuat_TruyenNhiemService _BenhAnTongQuat_TruyenNhiemService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_TruyenNhiemController(IBenhAnTongQuat_TruyenNhiemService BenhAnTongQuat_TruyenNhiemService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_TruyenNhiemService, WebHostEnvironment)
    {
    _BenhAnTongQuat_TruyenNhiemService = BenhAnTongQuat_TruyenNhiemService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

