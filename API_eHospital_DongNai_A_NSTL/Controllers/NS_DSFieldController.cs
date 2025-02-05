namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DSFieldController : BaseController<NS_DSField, INS_DSFieldService>
    {
    private readonly INS_DSFieldService _NS_DSFieldService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DSFieldController(INS_DSFieldService NS_DSFieldService, IWebHostEnvironment WebHostEnvironment) : base(NS_DSFieldService, WebHostEnvironment)
    {
    _NS_DSFieldService = NS_DSFieldService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

