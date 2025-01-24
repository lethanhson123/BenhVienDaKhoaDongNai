namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_LichCongTac_KetQuaController : BaseController<CDT_LichCongTac_KetQua, ICDT_LichCongTac_KetQuaService>
    {
    private readonly ICDT_LichCongTac_KetQuaService _CDT_LichCongTac_KetQuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_LichCongTac_KetQuaController(ICDT_LichCongTac_KetQuaService CDT_LichCongTac_KetQuaService, IWebHostEnvironment WebHostEnvironment) : base(CDT_LichCongTac_KetQuaService, WebHostEnvironment)
    {
    _CDT_LichCongTac_KetQuaService = CDT_LichCongTac_KetQuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

