namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class YTDP_KetQuaChiTietController : BaseController<YTDP_KetQuaChiTiet, IYTDP_KetQuaChiTietService>
    {
    private readonly IYTDP_KetQuaChiTietService _YTDP_KetQuaChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public YTDP_KetQuaChiTietController(IYTDP_KetQuaChiTietService YTDP_KetQuaChiTietService, IWebHostEnvironment WebHostEnvironment) : base(YTDP_KetQuaChiTietService, WebHostEnvironment)
    {
    _YTDP_KetQuaChiTietService = YTDP_KetQuaChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

