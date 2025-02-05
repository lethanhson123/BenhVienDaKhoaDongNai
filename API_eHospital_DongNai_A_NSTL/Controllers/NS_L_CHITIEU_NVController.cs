namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_L_CHITIEU_NVController : BaseController<NS_L_CHITIEU_NV, INS_L_CHITIEU_NVService>
    {
    private readonly INS_L_CHITIEU_NVService _NS_L_CHITIEU_NVService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_L_CHITIEU_NVController(INS_L_CHITIEU_NVService NS_L_CHITIEU_NVService, IWebHostEnvironment WebHostEnvironment) : base(NS_L_CHITIEU_NVService, WebHostEnvironment)
    {
    _NS_L_CHITIEU_NVService = NS_L_CHITIEU_NVService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

