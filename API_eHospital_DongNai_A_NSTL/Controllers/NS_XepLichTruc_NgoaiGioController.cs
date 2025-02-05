namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_XepLichTruc_NgoaiGioController : BaseController<NS_XepLichTruc_NgoaiGio, INS_XepLichTruc_NgoaiGioService>
    {
    private readonly INS_XepLichTruc_NgoaiGioService _NS_XepLichTruc_NgoaiGioService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_XepLichTruc_NgoaiGioController(INS_XepLichTruc_NgoaiGioService NS_XepLichTruc_NgoaiGioService, IWebHostEnvironment WebHostEnvironment) : base(NS_XepLichTruc_NgoaiGioService, WebHostEnvironment)
    {
    _NS_XepLichTruc_NgoaiGioService = NS_XepLichTruc_NgoaiGioService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

