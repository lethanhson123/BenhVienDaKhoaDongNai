namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_ThayDoiController : BaseController<KhamBenh_ThayDoi, IKhamBenh_ThayDoiService>
    {
    private readonly IKhamBenh_ThayDoiService _KhamBenh_ThayDoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamBenh_ThayDoiController(IKhamBenh_ThayDoiService KhamBenh_ThayDoiService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_ThayDoiService, WebHostEnvironment)
    {
    _KhamBenh_ThayDoiService = KhamBenh_ThayDoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

