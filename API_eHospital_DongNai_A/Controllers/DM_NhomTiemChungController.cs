namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_NhomTiemChungController : BaseController<DM_NhomTiemChung, IDM_NhomTiemChungService>
    {
    private readonly IDM_NhomTiemChungService _DM_NhomTiemChungService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_NhomTiemChungController(IDM_NhomTiemChungService DM_NhomTiemChungService, IWebHostEnvironment WebHostEnvironment) : base(DM_NhomTiemChungService, WebHostEnvironment)
    {
    _DM_NhomTiemChungService = DM_NhomTiemChungService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

