namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_DinhSuatController : BaseController<NS_DM_DinhSuat, INS_DM_DinhSuatService>
    {
    private readonly INS_DM_DinhSuatService _NS_DM_DinhSuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_DinhSuatController(INS_DM_DinhSuatService NS_DM_DinhSuatService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_DinhSuatService, WebHostEnvironment)
    {
    _NS_DM_DinhSuatService = NS_DM_DinhSuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

