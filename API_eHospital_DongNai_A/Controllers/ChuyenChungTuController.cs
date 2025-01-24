namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChuyenChungTuController : BaseController<ChuyenChungTu, IChuyenChungTuService>
    {
    private readonly IChuyenChungTuService _ChuyenChungTuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChuyenChungTuController(IChuyenChungTuService ChuyenChungTuService, IWebHostEnvironment WebHostEnvironment) : base(ChuyenChungTuService, WebHostEnvironment)
    {
    _ChuyenChungTuService = ChuyenChungTuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

