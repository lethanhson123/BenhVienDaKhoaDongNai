namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_TrangThietBiTuyenDuoiController : BaseController<DM_TrangThietBiTuyenDuoi, IDM_TrangThietBiTuyenDuoiService>
    {
    private readonly IDM_TrangThietBiTuyenDuoiService _DM_TrangThietBiTuyenDuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_TrangThietBiTuyenDuoiController(IDM_TrangThietBiTuyenDuoiService DM_TrangThietBiTuyenDuoiService, IWebHostEnvironment WebHostEnvironment) : base(DM_TrangThietBiTuyenDuoiService, WebHostEnvironment)
    {
    _DM_TrangThietBiTuyenDuoiService = DM_TrangThietBiTuyenDuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

