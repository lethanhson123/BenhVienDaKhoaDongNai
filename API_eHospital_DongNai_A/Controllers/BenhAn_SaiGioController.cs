namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAn_SaiGioController : BaseController<BenhAn_SaiGio, IBenhAn_SaiGioService>
    {
    private readonly IBenhAn_SaiGioService _BenhAn_SaiGioService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAn_SaiGioController(IBenhAn_SaiGioService BenhAn_SaiGioService, IWebHostEnvironment WebHostEnvironment) : base(BenhAn_SaiGioService, WebHostEnvironment)
    {
    _BenhAn_SaiGioService = BenhAn_SaiGioService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

