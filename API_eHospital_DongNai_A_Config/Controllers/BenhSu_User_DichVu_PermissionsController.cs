namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhSu_User_DichVu_PermissionsController : BaseController<BenhSu_User_DichVu_Permissions, IBenhSu_User_DichVu_PermissionsService>
    {
    private readonly IBenhSu_User_DichVu_PermissionsService _BenhSu_User_DichVu_PermissionsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhSu_User_DichVu_PermissionsController(IBenhSu_User_DichVu_PermissionsService BenhSu_User_DichVu_PermissionsService, IWebHostEnvironment WebHostEnvironment) : base(BenhSu_User_DichVu_PermissionsService, WebHostEnvironment)
    {
    _BenhSu_User_DichVu_PermissionsService = BenhSu_User_DichVu_PermissionsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

