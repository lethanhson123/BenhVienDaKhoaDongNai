namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Map_PB_Group_KiosController : BaseController<Map_PB_Group_Kios, IMap_PB_Group_KiosService>
    {
    private readonly IMap_PB_Group_KiosService _Map_PB_Group_KiosService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Map_PB_Group_KiosController(IMap_PB_Group_KiosService Map_PB_Group_KiosService, IWebHostEnvironment WebHostEnvironment) : base(Map_PB_Group_KiosService, WebHostEnvironment)
    {
    _Map_PB_Group_KiosService = Map_PB_Group_KiosService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

