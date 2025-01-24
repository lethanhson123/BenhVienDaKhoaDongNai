namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_PhacDoDieuTriController : BaseController<DM_PhacDoDieuTri, IDM_PhacDoDieuTriService>
    {
    private readonly IDM_PhacDoDieuTriService _DM_PhacDoDieuTriService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_PhacDoDieuTriController(IDM_PhacDoDieuTriService DM_PhacDoDieuTriService, IWebHostEnvironment WebHostEnvironment) : base(DM_PhacDoDieuTriService, WebHostEnvironment)
    {
    _DM_PhacDoDieuTriService = DM_PhacDoDieuTriService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

