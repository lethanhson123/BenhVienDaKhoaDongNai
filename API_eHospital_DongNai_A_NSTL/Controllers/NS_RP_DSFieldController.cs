namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_RP_DSFieldController : BaseController<NS_RP_DSField, INS_RP_DSFieldService>
    {
    private readonly INS_RP_DSFieldService _NS_RP_DSFieldService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_RP_DSFieldController(INS_RP_DSFieldService NS_RP_DSFieldService, IWebHostEnvironment WebHostEnvironment) : base(NS_RP_DSFieldService, WebHostEnvironment)
    {
    _NS_RP_DSFieldService = NS_RP_DSFieldService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

