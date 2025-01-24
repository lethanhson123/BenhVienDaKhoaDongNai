namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class UserTraKQXNController : BaseController<UserTraKQXN, IUserTraKQXNService>
    {
    private readonly IUserTraKQXNService _UserTraKQXNService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public UserTraKQXNController(IUserTraKQXNService UserTraKQXNService, IWebHostEnvironment WebHostEnvironment) : base(UserTraKQXNService, WebHostEnvironment)
    {
    _UserTraKQXNService = UserTraKQXNService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

