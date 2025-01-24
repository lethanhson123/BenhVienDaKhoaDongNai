namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaMauController : BaseController<CLSKetQuaMau, ICLSKetQuaMauService>
    {
    private readonly ICLSKetQuaMauService _CLSKetQuaMauService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaMauController(ICLSKetQuaMauService CLSKetQuaMauService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaMauService, WebHostEnvironment)
    {
    _CLSKetQuaMauService = CLSKetQuaMauService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

