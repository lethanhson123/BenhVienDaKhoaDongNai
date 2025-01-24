namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamSucKhoeChiTietController : BaseController<KhamSucKhoeChiTiet, IKhamSucKhoeChiTietService>
    {
    private readonly IKhamSucKhoeChiTietService _KhamSucKhoeChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamSucKhoeChiTietController(IKhamSucKhoeChiTietService KhamSucKhoeChiTietService, IWebHostEnvironment WebHostEnvironment) : base(KhamSucKhoeChiTietService, WebHostEnvironment)
    {
    _KhamSucKhoeChiTietService = KhamSucKhoeChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

