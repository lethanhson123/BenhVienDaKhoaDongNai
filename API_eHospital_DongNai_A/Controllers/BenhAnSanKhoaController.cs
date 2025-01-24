namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnSanKhoaController : BaseController<BenhAnSanKhoa, IBenhAnSanKhoaService>
    {
    private readonly IBenhAnSanKhoaService _BenhAnSanKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnSanKhoaController(IBenhAnSanKhoaService BenhAnSanKhoaService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnSanKhoaService, WebHostEnvironment)
    {
    _BenhAnSanKhoaService = BenhAnSanKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

