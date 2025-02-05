namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_CaTrucController : BaseController<NS_DM_CaTruc, INS_DM_CaTrucService>
    {
    private readonly INS_DM_CaTrucService _NS_DM_CaTrucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_CaTrucController(INS_DM_CaTrucService NS_DM_CaTrucService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_CaTrucService, WebHostEnvironment)
    {
    _NS_DM_CaTrucService = NS_DM_CaTrucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

