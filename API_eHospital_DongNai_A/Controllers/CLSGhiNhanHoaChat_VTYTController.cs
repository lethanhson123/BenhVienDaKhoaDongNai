namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSGhiNhanHoaChat_VTYTController : BaseController<CLSGhiNhanHoaChat_VTYT, ICLSGhiNhanHoaChat_VTYTService>
    {
    private readonly ICLSGhiNhanHoaChat_VTYTService _CLSGhiNhanHoaChat_VTYTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSGhiNhanHoaChat_VTYTController(ICLSGhiNhanHoaChat_VTYTService CLSGhiNhanHoaChat_VTYTService, IWebHostEnvironment WebHostEnvironment) : base(CLSGhiNhanHoaChat_VTYTService, WebHostEnvironment)
    {
    _CLSGhiNhanHoaChat_VTYTService = CLSGhiNhanHoaChat_VTYTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

