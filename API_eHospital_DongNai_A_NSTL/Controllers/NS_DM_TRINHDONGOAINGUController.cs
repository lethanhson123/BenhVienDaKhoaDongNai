namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_TRINHDONGOAINGUController : BaseController<NS_DM_TRINHDONGOAINGU, INS_DM_TRINHDONGOAINGUService>
    {
    private readonly INS_DM_TRINHDONGOAINGUService _NS_DM_TRINHDONGOAINGUService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_TRINHDONGOAINGUController(INS_DM_TRINHDONGOAINGUService NS_DM_TRINHDONGOAINGUService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_TRINHDONGOAINGUService, WebHostEnvironment)
    {
    _NS_DM_TRINHDONGOAINGUService = NS_DM_TRINHDONGOAINGUService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

