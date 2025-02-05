namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_TRINHDOController : BaseController<NS_DM_TRINHDO, INS_DM_TRINHDOService>
    {
    private readonly INS_DM_TRINHDOService _NS_DM_TRINHDOService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_TRINHDOController(INS_DM_TRINHDOService NS_DM_TRINHDOService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_TRINHDOService, WebHostEnvironment)
    {
    _NS_DM_TRINHDOService = NS_DM_TRINHDOService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

