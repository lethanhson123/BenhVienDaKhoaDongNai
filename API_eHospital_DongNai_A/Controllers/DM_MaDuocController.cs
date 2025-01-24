namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_MaDuocController : BaseController<DM_MaDuoc, IDM_MaDuocService>
    {
    private readonly IDM_MaDuocService _DM_MaDuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_MaDuocController(IDM_MaDuocService DM_MaDuocService, IWebHostEnvironment WebHostEnvironment) : base(DM_MaDuocService, WebHostEnvironment)
    {
    _DM_MaDuocService = DM_MaDuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

