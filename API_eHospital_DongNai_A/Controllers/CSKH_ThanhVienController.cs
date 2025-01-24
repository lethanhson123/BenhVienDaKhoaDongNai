namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_ThanhVienController : BaseController<CSKH_ThanhVien, ICSKH_ThanhVienService>
    {
    private readonly ICSKH_ThanhVienService _CSKH_ThanhVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_ThanhVienController(ICSKH_ThanhVienService CSKH_ThanhVienService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_ThanhVienService, WebHostEnvironment)
    {
    _CSKH_ThanhVienService = CSKH_ThanhVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

