namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_XepLichTrucController : BaseController<NS_XepLichTruc, INS_XepLichTrucService>
    {
    private readonly INS_XepLichTrucService _NS_XepLichTrucService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_XepLichTrucController(INS_XepLichTrucService NS_XepLichTrucService, IWebHostEnvironment WebHostEnvironment) : base(NS_XepLichTrucService, WebHostEnvironment)
    {
    _NS_XepLichTrucService = NS_XepLichTrucService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

