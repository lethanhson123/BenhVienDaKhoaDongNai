namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NhanVien_PhongBanController : BaseController<NS_NhanVien_PhongBan, INS_NhanVien_PhongBanService>
    {
    private readonly INS_NhanVien_PhongBanService _NS_NhanVien_PhongBanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NhanVien_PhongBanController(INS_NhanVien_PhongBanService NS_NhanVien_PhongBanService, IWebHostEnvironment WebHostEnvironment) : base(NS_NhanVien_PhongBanService, WebHostEnvironment)
    {
    _NS_NhanVien_PhongBanService = NS_NhanVien_PhongBanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

