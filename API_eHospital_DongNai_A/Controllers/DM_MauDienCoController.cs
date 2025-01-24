namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_MauDienCoController : BaseController<DM_MauDienCo, IDM_MauDienCoService>
    {
    private readonly IDM_MauDienCoService _DM_MauDienCoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_MauDienCoController(IDM_MauDienCoService DM_MauDienCoService, IWebHostEnvironment WebHostEnvironment) : base(DM_MauDienCoService, WebHostEnvironment)
    {
    _DM_MauDienCoService = DM_MauDienCoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

