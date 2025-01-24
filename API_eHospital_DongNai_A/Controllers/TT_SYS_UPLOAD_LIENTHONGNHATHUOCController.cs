namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TT_SYS_UPLOAD_LIENTHONGNHATHUOCController : BaseController<TT_SYS_UPLOAD_LIENTHONGNHATHUOC, ITT_SYS_UPLOAD_LIENTHONGNHATHUOCService>
    {
    private readonly ITT_SYS_UPLOAD_LIENTHONGNHATHUOCService _TT_SYS_UPLOAD_LIENTHONGNHATHUOCService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TT_SYS_UPLOAD_LIENTHONGNHATHUOCController(ITT_SYS_UPLOAD_LIENTHONGNHATHUOCService TT_SYS_UPLOAD_LIENTHONGNHATHUOCService, IWebHostEnvironment WebHostEnvironment) : base(TT_SYS_UPLOAD_LIENTHONGNHATHUOCService, WebHostEnvironment)
    {
    _TT_SYS_UPLOAD_LIENTHONGNHATHUOCService = TT_SYS_UPLOAD_LIENTHONGNHATHUOCService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

