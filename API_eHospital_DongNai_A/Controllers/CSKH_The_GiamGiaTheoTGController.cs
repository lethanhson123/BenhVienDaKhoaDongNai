namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_GiamGiaTheoTGController : BaseController<CSKH_The_GiamGiaTheoTG, ICSKH_The_GiamGiaTheoTGService>
    {
    private readonly ICSKH_The_GiamGiaTheoTGService _CSKH_The_GiamGiaTheoTGService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_GiamGiaTheoTGController(ICSKH_The_GiamGiaTheoTGService CSKH_The_GiamGiaTheoTGService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_GiamGiaTheoTGService, WebHostEnvironment)
    {
    _CSKH_The_GiamGiaTheoTGService = CSKH_The_GiamGiaTheoTGService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

