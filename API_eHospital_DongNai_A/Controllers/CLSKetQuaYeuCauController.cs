namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaYeuCauController : BaseController<CLSKetQuaYeuCau, ICLSKetQuaYeuCauService>
    {
    private readonly ICLSKetQuaYeuCauService _CLSKetQuaYeuCauService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaYeuCauController(ICLSKetQuaYeuCauService CLSKetQuaYeuCauService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaYeuCauService, WebHostEnvironment)
    {
    _CLSKetQuaYeuCauService = CLSKetQuaYeuCauService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

