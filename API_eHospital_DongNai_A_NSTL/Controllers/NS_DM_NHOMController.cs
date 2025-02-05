namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_NHOMController : BaseController<NS_DM_NHOM, INS_DM_NHOMService>
    {
    private readonly INS_DM_NHOMService _NS_DM_NHOMService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_NHOMController(INS_DM_NHOMService NS_DM_NHOMService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_NHOMService, WebHostEnvironment)
    {
    _NS_DM_NHOMService = NS_DM_NHOMService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

