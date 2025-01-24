namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GhiChuDuocController : BaseController<GhiChuDuoc, IGhiChuDuocService>
    {
    private readonly IGhiChuDuocService _GhiChuDuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GhiChuDuocController(IGhiChuDuocService GhiChuDuocService, IWebHostEnvironment WebHostEnvironment) : base(GhiChuDuocService, WebHostEnvironment)
    {
    _GhiChuDuocService = GhiChuDuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

