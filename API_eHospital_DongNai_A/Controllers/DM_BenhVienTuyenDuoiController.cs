namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_BenhVienTuyenDuoiController : BaseController<DM_BenhVienTuyenDuoi, IDM_BenhVienTuyenDuoiService>
    {
    private readonly IDM_BenhVienTuyenDuoiService _DM_BenhVienTuyenDuoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_BenhVienTuyenDuoiController(IDM_BenhVienTuyenDuoiService DM_BenhVienTuyenDuoiService, IWebHostEnvironment WebHostEnvironment) : base(DM_BenhVienTuyenDuoiService, WebHostEnvironment)
    {
    _DM_BenhVienTuyenDuoiService = DM_BenhVienTuyenDuoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

