namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GiaiPhauBenhSinhThietController : BaseController<GiaiPhauBenhSinhThiet, IGiaiPhauBenhSinhThietService>
    {
    private readonly IGiaiPhauBenhSinhThietService _GiaiPhauBenhSinhThietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GiaiPhauBenhSinhThietController(IGiaiPhauBenhSinhThietService GiaiPhauBenhSinhThietService, IWebHostEnvironment WebHostEnvironment) : base(GiaiPhauBenhSinhThietService, WebHostEnvironment)
    {
    _GiaiPhauBenhSinhThietService = GiaiPhauBenhSinhThietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

