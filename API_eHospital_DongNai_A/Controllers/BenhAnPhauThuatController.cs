namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnPhauThuatController : BaseController<BenhAnPhauThuat, IBenhAnPhauThuatService>
    {
    private readonly IBenhAnPhauThuatService _BenhAnPhauThuatService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnPhauThuatController(IBenhAnPhauThuatService BenhAnPhauThuatService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnPhauThuatService, WebHostEnvironment)
    {
    _BenhAnPhauThuatService = BenhAnPhauThuatService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

