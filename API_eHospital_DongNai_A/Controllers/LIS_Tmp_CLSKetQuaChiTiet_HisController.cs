namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LIS_Tmp_CLSKetQuaChiTiet_HisController : BaseController<LIS_Tmp_CLSKetQuaChiTiet_His, ILIS_Tmp_CLSKetQuaChiTiet_HisService>
    {
    private readonly ILIS_Tmp_CLSKetQuaChiTiet_HisService _LIS_Tmp_CLSKetQuaChiTiet_HisService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LIS_Tmp_CLSKetQuaChiTiet_HisController(ILIS_Tmp_CLSKetQuaChiTiet_HisService LIS_Tmp_CLSKetQuaChiTiet_HisService, IWebHostEnvironment WebHostEnvironment) : base(LIS_Tmp_CLSKetQuaChiTiet_HisService, WebHostEnvironment)
    {
    _LIS_Tmp_CLSKetQuaChiTiet_HisService = LIS_Tmp_CLSKetQuaChiTiet_HisService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

