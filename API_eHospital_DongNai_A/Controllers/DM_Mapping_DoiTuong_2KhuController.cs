namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_Mapping_DoiTuong_2KhuController : BaseController<DM_Mapping_DoiTuong_2Khu, IDM_Mapping_DoiTuong_2KhuService>
    {
    private readonly IDM_Mapping_DoiTuong_2KhuService _DM_Mapping_DoiTuong_2KhuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_Mapping_DoiTuong_2KhuController(IDM_Mapping_DoiTuong_2KhuService DM_Mapping_DoiTuong_2KhuService, IWebHostEnvironment WebHostEnvironment) : base(DM_Mapping_DoiTuong_2KhuService, WebHostEnvironment)
    {
    _DM_Mapping_DoiTuong_2KhuService = DM_Mapping_DoiTuong_2KhuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

