namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_KhuVuc_UserController : BaseController<me_KhuVuc_User, Ime_KhuVuc_UserService>
    {
    private readonly Ime_KhuVuc_UserService _me_KhuVuc_UserService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_KhuVuc_UserController(Ime_KhuVuc_UserService me_KhuVuc_UserService, IWebHostEnvironment WebHostEnvironment) : base(me_KhuVuc_UserService, WebHostEnvironment)
    {
    _me_KhuVuc_UserService = me_KhuVuc_UserService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

