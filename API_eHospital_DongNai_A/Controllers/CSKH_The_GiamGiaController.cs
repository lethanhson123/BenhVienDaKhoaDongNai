namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_The_GiamGiaController : BaseController<CSKH_The_GiamGia, ICSKH_The_GiamGiaService>
    {
    private readonly ICSKH_The_GiamGiaService _CSKH_The_GiamGiaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_The_GiamGiaController(ICSKH_The_GiamGiaService CSKH_The_GiamGiaService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_The_GiamGiaService, WebHostEnvironment)
    {
    _CSKH_The_GiamGiaService = CSKH_The_GiamGiaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

