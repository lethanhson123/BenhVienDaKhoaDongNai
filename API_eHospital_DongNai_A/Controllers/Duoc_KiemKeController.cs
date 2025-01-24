namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_KiemKeController : BaseController<Duoc_KiemKe, IDuoc_KiemKeService>
    {
    private readonly IDuoc_KiemKeService _Duoc_KiemKeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_KiemKeController(IDuoc_KiemKeService Duoc_KiemKeService, IWebHostEnvironment WebHostEnvironment) : base(Duoc_KiemKeService, WebHostEnvironment)
    {
    _Duoc_KiemKeService = Duoc_KiemKeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

