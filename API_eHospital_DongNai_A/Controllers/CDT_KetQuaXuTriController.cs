namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KetQuaXuTriController : BaseController<CDT_KetQuaXuTri, ICDT_KetQuaXuTriService>
    {
    private readonly ICDT_KetQuaXuTriService _CDT_KetQuaXuTriService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KetQuaXuTriController(ICDT_KetQuaXuTriService CDT_KetQuaXuTriService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KetQuaXuTriService, WebHostEnvironment)
    {
    _CDT_KetQuaXuTriService = CDT_KetQuaXuTriService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

