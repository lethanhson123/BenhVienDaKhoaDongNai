namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NhanVien_NhanVienController : BaseController<NS_NhanVien_NhanVien, INS_NhanVien_NhanVienService>
    {
    private readonly INS_NhanVien_NhanVienService _NS_NhanVien_NhanVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NhanVien_NhanVienController(INS_NhanVien_NhanVienService NS_NhanVien_NhanVienService, IWebHostEnvironment WebHostEnvironment) : base(NS_NhanVien_NhanVienService, WebHostEnvironment)
    {
    _NS_NhanVien_NhanVienService = NS_NhanVien_NhanVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

