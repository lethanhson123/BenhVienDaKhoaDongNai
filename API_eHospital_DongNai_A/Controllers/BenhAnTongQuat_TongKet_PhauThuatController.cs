namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnTongQuat_TongKet_PhauThuatController : BaseController<BenhAnTongQuat_TongKet_PhauThuat, IBenhAnTongQuat_TongKet_PhauThuatService>
    {
    private readonly IBenhAnTongQuat_TongKet_PhauThuatService _BenhAnTongQuat_TongKet_PhauThuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnTongQuat_TongKet_PhauThuatController(IBenhAnTongQuat_TongKet_PhauThuatService BenhAnTongQuat_TongKet_PhauThuatService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnTongQuat_TongKet_PhauThuatService, WebHostEnvironment)
    {
    _BenhAnTongQuat_TongKet_PhauThuatService = BenhAnTongQuat_TongKet_PhauThuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

