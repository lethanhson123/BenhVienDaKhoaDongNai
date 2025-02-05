namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_ThoiGianDiHocController : BaseController<NS_DM_ThoiGianDiHoc, INS_DM_ThoiGianDiHocService>
    {
    private readonly INS_DM_ThoiGianDiHocService _NS_DM_ThoiGianDiHocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_ThoiGianDiHocController(INS_DM_ThoiGianDiHocService NS_DM_ThoiGianDiHocService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_ThoiGianDiHocService, WebHostEnvironment)
    {
    _NS_DM_ThoiGianDiHocService = NS_DM_ThoiGianDiHocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

