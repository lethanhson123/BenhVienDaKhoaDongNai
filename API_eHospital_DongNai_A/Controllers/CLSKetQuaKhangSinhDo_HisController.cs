namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaKhangSinhDo_HisController : BaseController<CLSKetQuaKhangSinhDo_His, ICLSKetQuaKhangSinhDo_HisService>
    {
    private readonly ICLSKetQuaKhangSinhDo_HisService _CLSKetQuaKhangSinhDo_HisService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaKhangSinhDo_HisController(ICLSKetQuaKhangSinhDo_HisService CLSKetQuaKhangSinhDo_HisService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaKhangSinhDo_HisService, WebHostEnvironment)
    {
    _CLSKetQuaKhangSinhDo_HisService = CLSKetQuaKhangSinhDo_HisService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

