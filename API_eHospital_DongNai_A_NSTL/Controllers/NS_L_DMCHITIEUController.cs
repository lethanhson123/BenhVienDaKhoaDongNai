namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_L_DMCHITIEUController : BaseController<NS_L_DMCHITIEU, INS_L_DMCHITIEUService>
    {
    private readonly INS_L_DMCHITIEUService _NS_L_DMCHITIEUService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_L_DMCHITIEUController(INS_L_DMCHITIEUService NS_L_DMCHITIEUService, IWebHostEnvironment WebHostEnvironment) : base(NS_L_DMCHITIEUService, WebHostEnvironment)
    {
    _NS_L_DMCHITIEUService = NS_L_DMCHITIEUService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

