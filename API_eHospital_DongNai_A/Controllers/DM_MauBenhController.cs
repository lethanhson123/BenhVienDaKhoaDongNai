namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_MauBenhController : BaseController<DM_MauBenh, IDM_MauBenhService>
    {
    private readonly IDM_MauBenhService _DM_MauBenhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_MauBenhController(IDM_MauBenhService DM_MauBenhService, IWebHostEnvironment WebHostEnvironment) : base(DM_MauBenhService, WebHostEnvironment)
    {
    _DM_MauBenhService = DM_MauBenhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

