namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_GiamGia_CTTronGoiController : BaseController<CSKH_The_GiamGia_CTTronGoi, ICSKH_The_GiamGia_CTTronGoiService>
    {
    private readonly ICSKH_The_GiamGia_CTTronGoiService _CSKH_The_GiamGia_CTTronGoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_GiamGia_CTTronGoiController(ICSKH_The_GiamGia_CTTronGoiService CSKH_The_GiamGia_CTTronGoiService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_GiamGia_CTTronGoiService, WebHostEnvironment)
    {
    _CSKH_The_GiamGia_CTTronGoiService = CSKH_The_GiamGia_CTTronGoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

