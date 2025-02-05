namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_ThiDuaController : BaseController<NS_ThiDua, INS_ThiDuaService>
    {
    private readonly INS_ThiDuaService _NS_ThiDuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_ThiDuaController(INS_ThiDuaService NS_ThiDuaService, IWebHostEnvironment WebHostEnvironment) : base(NS_ThiDuaService, WebHostEnvironment)
    {
    _NS_ThiDuaService = NS_ThiDuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

