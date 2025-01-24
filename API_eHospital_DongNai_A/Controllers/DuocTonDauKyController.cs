namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocTonDauKyController : BaseController<DuocTonDauKy, IDuocTonDauKyService>
    {
    private readonly IDuocTonDauKyService _DuocTonDauKyService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocTonDauKyController(IDuocTonDauKyService DuocTonDauKyService, IWebHostEnvironment WebHostEnvironment) : base(DuocTonDauKyService, WebHostEnvironment)
    {
    _DuocTonDauKyService = DuocTonDauKyService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

