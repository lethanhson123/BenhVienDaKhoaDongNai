namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TiepNhanCapCuuController : BaseController<TiepNhanCapCuu, ITiepNhanCapCuuService>
    {
    private readonly ITiepNhanCapCuuService _TiepNhanCapCuuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TiepNhanCapCuuController(ITiepNhanCapCuuService TiepNhanCapCuuService, IWebHostEnvironment WebHostEnvironment) : base(TiepNhanCapCuuService, WebHostEnvironment)
    {
    _TiepNhanCapCuuService = TiepNhanCapCuuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

