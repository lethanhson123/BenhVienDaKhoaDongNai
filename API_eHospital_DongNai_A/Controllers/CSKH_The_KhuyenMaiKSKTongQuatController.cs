namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_KhuyenMaiKSKTongQuatController : BaseController<CSKH_The_KhuyenMaiKSKTongQuat, ICSKH_The_KhuyenMaiKSKTongQuatService>
    {
    private readonly ICSKH_The_KhuyenMaiKSKTongQuatService _CSKH_The_KhuyenMaiKSKTongQuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_KhuyenMaiKSKTongQuatController(ICSKH_The_KhuyenMaiKSKTongQuatService CSKH_The_KhuyenMaiKSKTongQuatService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_KhuyenMaiKSKTongQuatService, WebHostEnvironment)
    {
    _CSKH_The_KhuyenMaiKSKTongQuatService = CSKH_The_KhuyenMaiKSKTongQuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

