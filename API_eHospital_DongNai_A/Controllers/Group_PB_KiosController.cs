namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Group_PB_KiosController : BaseController<Group_PB_Kios, IGroup_PB_KiosService>
    {
    private readonly IGroup_PB_KiosService _Group_PB_KiosService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Group_PB_KiosController(IGroup_PB_KiosService Group_PB_KiosService, IWebHostEnvironment WebHostEnvironment) : base(Group_PB_KiosService, WebHostEnvironment)
    {
    _Group_PB_KiosService = Group_PB_KiosService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

