namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_LICHTRUCController : BaseController<NS_LICHTRUC, INS_LICHTRUCService>
    {
    private readonly INS_LICHTRUCService _NS_LICHTRUCService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_LICHTRUCController(INS_LICHTRUCService NS_LICHTRUCService, IWebHostEnvironment WebHostEnvironment) : base(NS_LICHTRUCService, WebHostEnvironment)
    {
    _NS_LICHTRUCService = NS_LICHTRUCService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

