namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HOADON_PAYRESULTController : BaseController<HOADON_PAYRESULT, IHOADON_PAYRESULTService>
    {
    private readonly IHOADON_PAYRESULTService _HOADON_PAYRESULTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HOADON_PAYRESULTController(IHOADON_PAYRESULTService HOADON_PAYRESULTService, IWebHostEnvironment WebHostEnvironment) : base(HOADON_PAYRESULTService, WebHostEnvironment)
    {
    _HOADON_PAYRESULTService = HOADON_PAYRESULTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

