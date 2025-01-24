namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NhanVien_KSK_NgoaiVienController : BaseController<NhanVien_KSK_NgoaiVien, INhanVien_KSK_NgoaiVienService>
    {
    private readonly INhanVien_KSK_NgoaiVienService _NhanVien_KSK_NgoaiVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NhanVien_KSK_NgoaiVienController(INhanVien_KSK_NgoaiVienService NhanVien_KSK_NgoaiVienService, IWebHostEnvironment WebHostEnvironment) : base(NhanVien_KSK_NgoaiVienService, WebHostEnvironment)
    {
    _NhanVien_KSK_NgoaiVienService = NhanVien_KSK_NgoaiVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

