namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuLinhDuocController : BaseController<PhieuLinhDuoc, IPhieuLinhDuocService>
    {
    private readonly IPhieuLinhDuocService _PhieuLinhDuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuLinhDuocController(IPhieuLinhDuocService PhieuLinhDuocService, IWebHostEnvironment WebHostEnvironment) : base(PhieuLinhDuocService, WebHostEnvironment)
    {
    _PhieuLinhDuocService = PhieuLinhDuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

