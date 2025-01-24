namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_CDT_LoaiController : BaseController<DM_CDT_Loai, IDM_CDT_LoaiService>
    {
    private readonly IDM_CDT_LoaiService _DM_CDT_LoaiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_CDT_LoaiController(IDM_CDT_LoaiService DM_CDT_LoaiService, IWebHostEnvironment WebHostEnvironment) : base(DM_CDT_LoaiService, WebHostEnvironment)
    {
    _DM_CDT_LoaiService = DM_CDT_LoaiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

