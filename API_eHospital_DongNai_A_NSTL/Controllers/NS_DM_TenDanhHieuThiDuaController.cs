namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_TenDanhHieuThiDuaController : BaseController<NS_DM_TenDanhHieuThiDua, INS_DM_TenDanhHieuThiDuaService>
    {
    private readonly INS_DM_TenDanhHieuThiDuaService _NS_DM_TenDanhHieuThiDuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_TenDanhHieuThiDuaController(INS_DM_TenDanhHieuThiDuaService NS_DM_TenDanhHieuThiDuaService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_TenDanhHieuThiDuaService, WebHostEnvironment)
    {
    _NS_DM_TenDanhHieuThiDuaService = NS_DM_TenDanhHieuThiDuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

