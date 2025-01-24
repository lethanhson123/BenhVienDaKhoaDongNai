namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQua_VersionController : BaseController<CLSKetQua_Version, ICLSKetQua_VersionService>
    {
    private readonly ICLSKetQua_VersionService _CLSKetQua_VersionService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQua_VersionController(ICLSKetQua_VersionService CLSKetQua_VersionService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQua_VersionService, WebHostEnvironment)
    {
    _CLSKetQua_VersionService = CLSKetQua_VersionService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

