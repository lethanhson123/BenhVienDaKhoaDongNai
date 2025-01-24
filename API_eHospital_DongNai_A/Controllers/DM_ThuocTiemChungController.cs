namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ThuocTiemChungController : BaseController<DM_ThuocTiemChung, IDM_ThuocTiemChungService>
    {
    private readonly IDM_ThuocTiemChungService _DM_ThuocTiemChungService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_ThuocTiemChungController(IDM_ThuocTiemChungService DM_ThuocTiemChungService, IWebHostEnvironment WebHostEnvironment) : base(DM_ThuocTiemChungService, WebHostEnvironment)
    {
    _DM_ThuocTiemChungService = DM_ThuocTiemChungService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

