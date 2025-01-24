namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_ChuyenDoiLoaiThanhVienController : BaseController<CSKH_The_ChuyenDoiLoaiThanhVien, ICSKH_The_ChuyenDoiLoaiThanhVienService>
    {
    private readonly ICSKH_The_ChuyenDoiLoaiThanhVienService _CSKH_The_ChuyenDoiLoaiThanhVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_ChuyenDoiLoaiThanhVienController(ICSKH_The_ChuyenDoiLoaiThanhVienService CSKH_The_ChuyenDoiLoaiThanhVienService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_ChuyenDoiLoaiThanhVienService, WebHostEnvironment)
    {
    _CSKH_The_ChuyenDoiLoaiThanhVienService = CSKH_The_ChuyenDoiLoaiThanhVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

