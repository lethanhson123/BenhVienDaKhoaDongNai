namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DoiTuongController : BaseController<DM_DoiTuong, IDM_DoiTuongService>
    {
    private readonly IDM_DoiTuongService _DM_DoiTuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_DoiTuongController(IDM_DoiTuongService DM_DoiTuongService, IWebHostEnvironment WebHostEnvironment) : base(DM_DoiTuongService, WebHostEnvironment)
    {
    _DM_DoiTuongService = DM_DoiTuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

