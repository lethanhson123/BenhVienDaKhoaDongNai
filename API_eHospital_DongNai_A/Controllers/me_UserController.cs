namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_UserController : BaseController<me_User, Ime_UserService>
    {
    private readonly Ime_UserService _me_UserService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_UserController(Ime_UserService me_UserService, IWebHostEnvironment WebHostEnvironment) : base(me_UserService, WebHostEnvironment)
    {
    _me_UserService = me_UserService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

