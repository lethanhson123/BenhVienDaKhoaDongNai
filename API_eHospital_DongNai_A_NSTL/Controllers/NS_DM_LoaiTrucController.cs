namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_LoaiTrucController : BaseController<NS_DM_LoaiTruc, INS_DM_LoaiTrucService>
    {
    private readonly INS_DM_LoaiTrucService _NS_DM_LoaiTrucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_LoaiTrucController(INS_DM_LoaiTrucService NS_DM_LoaiTrucService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_LoaiTrucService, WebHostEnvironment)
    {
    _NS_DM_LoaiTrucService = NS_DM_LoaiTrucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

