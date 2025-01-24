namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaXNHuyet_TuyDoController : BaseController<CLSKetQuaXNHuyet_TuyDo, ICLSKetQuaXNHuyet_TuyDoService>
    {
    private readonly ICLSKetQuaXNHuyet_TuyDoService _CLSKetQuaXNHuyet_TuyDoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaXNHuyet_TuyDoController(ICLSKetQuaXNHuyet_TuyDoService CLSKetQuaXNHuyet_TuyDoService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaXNHuyet_TuyDoService, WebHostEnvironment)
    {
    _CLSKetQuaXNHuyet_TuyDoService = CLSKetQuaXNHuyet_TuyDoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

