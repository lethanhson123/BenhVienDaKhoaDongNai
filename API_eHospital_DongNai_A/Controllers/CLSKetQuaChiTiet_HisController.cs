namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaChiTiet_HisController : BaseController<CLSKetQuaChiTiet_His, ICLSKetQuaChiTiet_HisService>
    {
    private readonly ICLSKetQuaChiTiet_HisService _CLSKetQuaChiTiet_HisService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaChiTiet_HisController(ICLSKetQuaChiTiet_HisService CLSKetQuaChiTiet_HisService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaChiTiet_HisService, WebHostEnvironment)
    {
    _CLSKetQuaChiTiet_HisService = CLSKetQuaChiTiet_HisService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

