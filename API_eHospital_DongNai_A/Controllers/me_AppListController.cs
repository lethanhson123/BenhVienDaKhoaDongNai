namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_AppListController : BaseController<me_AppList, Ime_AppListService>
    {
    private readonly Ime_AppListService _me_AppListService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_AppListController(Ime_AppListService me_AppListService, IWebHostEnvironment WebHostEnvironment) : base(me_AppListService, WebHostEnvironment)
    {
    _me_AppListService = me_AppListService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

