namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DuocGiaVonController : BaseController<DuocGiaVon, IDuocGiaVonService>
    {
    private readonly IDuocGiaVonService _DuocGiaVonService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DuocGiaVonController(IDuocGiaVonService DuocGiaVonService, IWebHostEnvironment WebHostEnvironment) : base(DuocGiaVonService, WebHostEnvironment)
    {
    _DuocGiaVonService = DuocGiaVonService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

