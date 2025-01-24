namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TiepNhan_BHYT_CuController : BaseController<TiepNhan_BHYT_Cu, ITiepNhan_BHYT_CuService>
    {
    private readonly ITiepNhan_BHYT_CuService _TiepNhan_BHYT_CuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TiepNhan_BHYT_CuController(ITiepNhan_BHYT_CuService TiepNhan_BHYT_CuService, IWebHostEnvironment WebHostEnvironment) : base(TiepNhan_BHYT_CuService, WebHostEnvironment)
    {
    _TiepNhan_BHYT_CuService = TiepNhan_BHYT_CuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

