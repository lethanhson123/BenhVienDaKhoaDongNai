namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class MienGiamNoiTruChiTietController : BaseController<MienGiamNoiTruChiTiet, IMienGiamNoiTruChiTietService>
    {
    private readonly IMienGiamNoiTruChiTietService _MienGiamNoiTruChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public MienGiamNoiTruChiTietController(IMienGiamNoiTruChiTietService MienGiamNoiTruChiTietService, IWebHostEnvironment WebHostEnvironment) : base(MienGiamNoiTruChiTietService, WebHostEnvironment)
    {
    _MienGiamNoiTruChiTietService = MienGiamNoiTruChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

