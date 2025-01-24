namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_TiemChungController : BaseController<KhamBenh_TiemChung, IKhamBenh_TiemChungService>
    {
    private readonly IKhamBenh_TiemChungService _KhamBenh_TiemChungService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamBenh_TiemChungController(IKhamBenh_TiemChungService KhamBenh_TiemChungService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_TiemChungService, WebHostEnvironment)
    {
    _KhamBenh_TiemChungService = KhamBenh_TiemChungService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

