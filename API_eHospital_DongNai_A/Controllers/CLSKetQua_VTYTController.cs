namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQua_VTYTController : BaseController<CLSKetQua_VTYT, ICLSKetQua_VTYTService>
    {
    private readonly ICLSKetQua_VTYTService _CLSKetQua_VTYTService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQua_VTYTController(ICLSKetQua_VTYTService CLSKetQua_VTYTService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQua_VTYTService, WebHostEnvironment)
    {
    _CLSKetQua_VTYTService = CLSKetQua_VTYTService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

