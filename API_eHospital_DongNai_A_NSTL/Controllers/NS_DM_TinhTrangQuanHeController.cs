namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_TinhTrangQuanHeController : BaseController<NS_DM_TinhTrangQuanHe, INS_DM_TinhTrangQuanHeService>
    {
    private readonly INS_DM_TinhTrangQuanHeService _NS_DM_TinhTrangQuanHeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_TinhTrangQuanHeController(INS_DM_TinhTrangQuanHeService NS_DM_TinhTrangQuanHeService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_TinhTrangQuanHeService, WebHostEnvironment)
    {
    _NS_DM_TinhTrangQuanHeService = NS_DM_TinhTrangQuanHeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

