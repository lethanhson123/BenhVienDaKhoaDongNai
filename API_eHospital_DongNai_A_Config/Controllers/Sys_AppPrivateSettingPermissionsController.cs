namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_AppPrivateSettingPermissionsController : BaseController<Sys_AppPrivateSettingPermissions, ISys_AppPrivateSettingPermissionsService>
    {
    private readonly ISys_AppPrivateSettingPermissionsService _Sys_AppPrivateSettingPermissionsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Sys_AppPrivateSettingPermissionsController(ISys_AppPrivateSettingPermissionsService Sys_AppPrivateSettingPermissionsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_AppPrivateSettingPermissionsService, WebHostEnvironment)
    {
    _Sys_AppPrivateSettingPermissionsService = Sys_AppPrivateSettingPermissionsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

