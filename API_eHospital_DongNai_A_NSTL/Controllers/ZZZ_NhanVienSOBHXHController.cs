namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ZZZ_NhanVienSOBHXHController : BaseController<ZZZ_NhanVienSOBHXH, IZZZ_NhanVienSOBHXHService>
    {
    private readonly IZZZ_NhanVienSOBHXHService _ZZZ_NhanVienSOBHXHService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ZZZ_NhanVienSOBHXHController(IZZZ_NhanVienSOBHXHService ZZZ_NhanVienSOBHXHService, IWebHostEnvironment WebHostEnvironment) : base(ZZZ_NhanVienSOBHXHService, WebHostEnvironment)
    {
    _ZZZ_NhanVienSOBHXHService = ZZZ_NhanVienSOBHXHService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

