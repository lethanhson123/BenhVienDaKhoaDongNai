namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_DM_CuaController : BaseController<me_DM_Cua, Ime_DM_CuaService>
    {
    private readonly Ime_DM_CuaService _me_DM_CuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_DM_CuaController(Ime_DM_CuaService me_DM_CuaService, IWebHostEnvironment WebHostEnvironment) : base(me_DM_CuaService, WebHostEnvironment)
    {
    _me_DM_CuaService = me_DM_CuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

