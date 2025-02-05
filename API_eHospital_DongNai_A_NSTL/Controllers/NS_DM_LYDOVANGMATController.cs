namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_LYDOVANGMATController : BaseController<NS_DM_LYDOVANGMAT, INS_DM_LYDOVANGMATService>
    {
    private readonly INS_DM_LYDOVANGMATService _NS_DM_LYDOVANGMATService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_LYDOVANGMATController(INS_DM_LYDOVANGMATService NS_DM_LYDOVANGMATService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_LYDOVANGMATService, WebHostEnvironment)
    {
    _NS_DM_LYDOVANGMATService = NS_DM_LYDOVANGMATService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

