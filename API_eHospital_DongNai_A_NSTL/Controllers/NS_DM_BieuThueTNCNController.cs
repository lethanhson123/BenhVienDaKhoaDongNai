namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_BieuThueTNCNController : BaseController<NS_DM_BieuThueTNCN, INS_DM_BieuThueTNCNService>
    {
    private readonly INS_DM_BieuThueTNCNService _NS_DM_BieuThueTNCNService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_BieuThueTNCNController(INS_DM_BieuThueTNCNService NS_DM_BieuThueTNCNService, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_BieuThueTNCNService, WebHostEnvironment)
    {
    _NS_DM_BieuThueTNCNService = NS_DM_BieuThueTNCNService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

