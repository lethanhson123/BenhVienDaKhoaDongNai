namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_BANGCAP_UVController : BaseController<NS_BANGCAP_UV, INS_BANGCAP_UVService>
    {
    private readonly INS_BANGCAP_UVService _NS_BANGCAP_UVService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_BANGCAP_UVController(INS_BANGCAP_UVService NS_BANGCAP_UVService, IWebHostEnvironment WebHostEnvironment) : base(NS_BANGCAP_UVService, WebHostEnvironment)
    {
    _NS_BANGCAP_UVService = NS_BANGCAP_UVService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

