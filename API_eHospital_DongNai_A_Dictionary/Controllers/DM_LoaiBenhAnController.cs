namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_LoaiBenhAnController : BaseController<DM_LoaiBenhAn, IDM_LoaiBenhAnService>
    {
    private readonly IDM_LoaiBenhAnService _DM_LoaiBenhAnService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_LoaiBenhAnController(IDM_LoaiBenhAnService DM_LoaiBenhAnService, IWebHostEnvironment WebHostEnvironment) : base(DM_LoaiBenhAnService, WebHostEnvironment)
    {
    _DM_LoaiBenhAnService = DM_LoaiBenhAnService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

