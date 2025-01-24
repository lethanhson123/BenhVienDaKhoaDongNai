namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class YTDP_KetQuaController : BaseController<YTDP_KetQua, IYTDP_KetQuaService>
    {
    private readonly IYTDP_KetQuaService _YTDP_KetQuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public YTDP_KetQuaController(IYTDP_KetQuaService YTDP_KetQuaService, IWebHostEnvironment WebHostEnvironment) : base(YTDP_KetQuaService, WebHostEnvironment)
    {
    _YTDP_KetQuaService = YTDP_KetQuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

