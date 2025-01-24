namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ToaThuocMauController : BaseController<ToaThuocMau, IToaThuocMauService>
    {
    private readonly IToaThuocMauService _ToaThuocMauService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ToaThuocMauController(IToaThuocMauService ToaThuocMauService, IWebHostEnvironment WebHostEnvironment) : base(ToaThuocMauService, WebHostEnvironment)
    {
    _ToaThuocMauService = ToaThuocMauService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

