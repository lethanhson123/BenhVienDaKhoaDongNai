namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_AppPrivateSettingItemsController : BaseController<Sys_AppPrivateSettingItems, ISys_AppPrivateSettingItemsService>
    {
    private readonly ISys_AppPrivateSettingItemsService _Sys_AppPrivateSettingItemsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_AppPrivateSettingItemsController(ISys_AppPrivateSettingItemsService Sys_AppPrivateSettingItemsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_AppPrivateSettingItemsService, WebHostEnvironment)
    {
    _Sys_AppPrivateSettingItemsService = Sys_AppPrivateSettingItemsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

