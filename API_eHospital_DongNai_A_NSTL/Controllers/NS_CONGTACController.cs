namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_CONGTACController : BaseController<NS_CONGTAC, INS_CONGTACService>
    {
    private readonly INS_CONGTACService _NS_CONGTACService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_CONGTACController(INS_CONGTACService NS_CONGTACService, IWebHostEnvironment WebHostEnvironment) : base(NS_CONGTACService, WebHostEnvironment)
    {
    _NS_CONGTACService = NS_CONGTACService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

