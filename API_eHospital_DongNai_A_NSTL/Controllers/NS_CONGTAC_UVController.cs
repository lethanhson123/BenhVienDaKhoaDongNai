namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_CONGTAC_UVController : BaseController<NS_CONGTAC_UV, INS_CONGTAC_UVService>
    {
    private readonly INS_CONGTAC_UVService _NS_CONGTAC_UVService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_CONGTAC_UVController(INS_CONGTAC_UVService NS_CONGTAC_UVService, IWebHostEnvironment WebHostEnvironment) : base(NS_CONGTAC_UVService, WebHostEnvironment)
    {
    _NS_CONGTAC_UVService = NS_CONGTAC_UVService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

