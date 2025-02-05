namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_HopDongController : BaseController<NS_DM_HopDong, INS_DM_HopDongService>
    {
    private readonly INS_DM_HopDongService _NS_DM_HopDongService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_HopDongController(INS_DM_HopDongService NS_DM_HopDongService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_HopDongService, WebHostEnvironment)
    {
    _NS_DM_HopDongService = NS_DM_HopDongService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

