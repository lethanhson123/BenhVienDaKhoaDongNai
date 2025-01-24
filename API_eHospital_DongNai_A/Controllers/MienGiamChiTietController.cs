namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class MienGiamChiTietController : BaseController<MienGiamChiTiet, IMienGiamChiTietService>
    {
    private readonly IMienGiamChiTietService _MienGiamChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public MienGiamChiTietController(IMienGiamChiTietService MienGiamChiTietService, IWebHostEnvironment WebHostEnvironment) : base(MienGiamChiTietService, WebHostEnvironment)
    {
    _MienGiamChiTietService = MienGiamChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

