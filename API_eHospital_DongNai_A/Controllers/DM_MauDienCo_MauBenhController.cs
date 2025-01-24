namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_MauDienCo_MauBenhController : BaseController<DM_MauDienCo_MauBenh, IDM_MauDienCo_MauBenhService>
    {
    private readonly IDM_MauDienCo_MauBenhService _DM_MauDienCo_MauBenhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_MauDienCo_MauBenhController(IDM_MauDienCo_MauBenhService DM_MauDienCo_MauBenhService, IWebHostEnvironment WebHostEnvironment) : base(DM_MauDienCo_MauBenhService, WebHostEnvironment)
    {
    _DM_MauDienCo_MauBenhService = DM_MauDienCo_MauBenhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

