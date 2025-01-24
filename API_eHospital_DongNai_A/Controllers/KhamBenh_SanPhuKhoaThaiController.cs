namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_SanPhuKhoaThaiController : BaseController<KhamBenh_SanPhuKhoaThai, IKhamBenh_SanPhuKhoaThaiService>
    {
    private readonly IKhamBenh_SanPhuKhoaThaiService _KhamBenh_SanPhuKhoaThaiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamBenh_SanPhuKhoaThaiController(IKhamBenh_SanPhuKhoaThaiService KhamBenh_SanPhuKhoaThaiService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_SanPhuKhoaThaiService, WebHostEnvironment)
    {
    _KhamBenh_SanPhuKhoaThaiService = KhamBenh_SanPhuKhoaThaiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

