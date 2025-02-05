namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_HOPDONGLAODONGController : BaseController<NS_HOPDONGLAODONG, INS_HOPDONGLAODONGService>
    {
    private readonly INS_HOPDONGLAODONGService _NS_HOPDONGLAODONGService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_HOPDONGLAODONGController(INS_HOPDONGLAODONGService NS_HOPDONGLAODONGService, IWebHostEnvironment WebHostEnvironment) : base(NS_HOPDONGLAODONGService, WebHostEnvironment)
    {
    _NS_HOPDONGLAODONGService = NS_HOPDONGLAODONGService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

