namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaChiTiet_VersionController : BaseController<CLSKetQuaChiTiet_Version, ICLSKetQuaChiTiet_VersionService>
    {
    private readonly ICLSKetQuaChiTiet_VersionService _CLSKetQuaChiTiet_VersionService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSKetQuaChiTiet_VersionController(ICLSKetQuaChiTiet_VersionService CLSKetQuaChiTiet_VersionService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaChiTiet_VersionService, WebHostEnvironment)
    {
    _CLSKetQuaChiTiet_VersionService = CLSKetQuaChiTiet_VersionService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

