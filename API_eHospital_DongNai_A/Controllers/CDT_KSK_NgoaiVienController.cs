namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KSK_NgoaiVienController : BaseController<CDT_KSK_NgoaiVien, ICDT_KSK_NgoaiVienService>
    {
    private readonly ICDT_KSK_NgoaiVienService _CDT_KSK_NgoaiVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KSK_NgoaiVienController(ICDT_KSK_NgoaiVienService CDT_KSK_NgoaiVienService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KSK_NgoaiVienService, WebHostEnvironment)
    {
    _CDT_KSK_NgoaiVienService = CDT_KSK_NgoaiVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

