namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TiepNhanCapCuuChiTietController : BaseController<TiepNhanCapCuuChiTiet, ITiepNhanCapCuuChiTietService>
    {
    private readonly ITiepNhanCapCuuChiTietService _TiepNhanCapCuuChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TiepNhanCapCuuChiTietController(ITiepNhanCapCuuChiTietService TiepNhanCapCuuChiTietService, IWebHostEnvironment WebHostEnvironment) : base(TiepNhanCapCuuChiTietService, WebHostEnvironment)
    {
    _TiepNhanCapCuuChiTietService = TiepNhanCapCuuChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

