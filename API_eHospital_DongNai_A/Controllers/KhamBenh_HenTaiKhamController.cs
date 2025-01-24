namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_HenTaiKhamController : BaseController<KhamBenh_HenTaiKham, IKhamBenh_HenTaiKhamService>
    {
    private readonly IKhamBenh_HenTaiKhamService _KhamBenh_HenTaiKhamService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamBenh_HenTaiKhamController(IKhamBenh_HenTaiKhamService KhamBenh_HenTaiKhamService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_HenTaiKhamService, WebHostEnvironment)
    {
    _KhamBenh_HenTaiKhamService = KhamBenh_HenTaiKhamService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

