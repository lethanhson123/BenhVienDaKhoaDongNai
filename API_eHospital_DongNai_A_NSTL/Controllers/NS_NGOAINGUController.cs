namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NGOAINGUController : BaseController<NS_NGOAINGU, INS_NGOAINGUService>
    {
    private readonly INS_NGOAINGUService _NS_NGOAINGUService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NGOAINGUController(INS_NGOAINGUService NS_NGOAINGUService, IWebHostEnvironment WebHostEnvironment) : base(NS_NGOAINGUService, WebHostEnvironment)
    {
    _NS_NGOAINGUService = NS_NGOAINGUService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

