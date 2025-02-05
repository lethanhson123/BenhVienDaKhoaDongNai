namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NGACHBACLUONGController : BaseController<NS_NGACHBACLUONG, INS_NGACHBACLUONGService>
    {
    private readonly INS_NGACHBACLUONGService _NS_NGACHBACLUONGService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NGACHBACLUONGController(INS_NGACHBACLUONGService NS_NGACHBACLUONGService, IWebHostEnvironment WebHostEnvironment) : base(NS_NGACHBACLUONGService, WebHostEnvironment)
    {
    _NS_NGACHBACLUONGService = NS_NGACHBACLUONGService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

