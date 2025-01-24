namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GiayRaVienController : BaseController<GiayRaVien, IGiayRaVienService>
    {
    private readonly IGiayRaVienService _GiayRaVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GiayRaVienController(IGiayRaVienService GiayRaVienService, IWebHostEnvironment WebHostEnvironment) : base(GiayRaVienService, WebHostEnvironment)
    {
    _GiayRaVienService = GiayRaVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

