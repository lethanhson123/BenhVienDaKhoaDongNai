namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_PHUCAPTRUCController : BaseController<NS_DM_PHUCAPTRUC, INS_DM_PHUCAPTRUCService>
    {
    private readonly INS_DM_PHUCAPTRUCService _NS_DM_PHUCAPTRUCService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_PHUCAPTRUCController(INS_DM_PHUCAPTRUCService NS_DM_PHUCAPTRUCService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_PHUCAPTRUCService, WebHostEnvironment)
    {
    _NS_DM_PHUCAPTRUCService = NS_DM_PHUCAPTRUCService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

