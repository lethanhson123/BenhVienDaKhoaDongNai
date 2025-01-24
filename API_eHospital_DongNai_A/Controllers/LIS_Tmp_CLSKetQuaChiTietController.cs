namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LIS_Tmp_CLSKetQuaChiTietController : BaseController<LIS_Tmp_CLSKetQuaChiTiet, ILIS_Tmp_CLSKetQuaChiTietService>
    {
    private readonly ILIS_Tmp_CLSKetQuaChiTietService _LIS_Tmp_CLSKetQuaChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LIS_Tmp_CLSKetQuaChiTietController(ILIS_Tmp_CLSKetQuaChiTietService LIS_Tmp_CLSKetQuaChiTietService, IWebHostEnvironment WebHostEnvironment) : base(LIS_Tmp_CLSKetQuaChiTietService, WebHostEnvironment)
    {
    _LIS_Tmp_CLSKetQuaChiTietService = LIS_Tmp_CLSKetQuaChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

