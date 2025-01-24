namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KSK_PhanLoaiDoiTuongController : BaseController<CDT_KSK_PhanLoaiDoiTuong, ICDT_KSK_PhanLoaiDoiTuongService>
    {
    private readonly ICDT_KSK_PhanLoaiDoiTuongService _CDT_KSK_PhanLoaiDoiTuongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KSK_PhanLoaiDoiTuongController(ICDT_KSK_PhanLoaiDoiTuongService CDT_KSK_PhanLoaiDoiTuongService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KSK_PhanLoaiDoiTuongService, WebHostEnvironment)
    {
    _CDT_KSK_PhanLoaiDoiTuongService = CDT_KSK_PhanLoaiDoiTuongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

