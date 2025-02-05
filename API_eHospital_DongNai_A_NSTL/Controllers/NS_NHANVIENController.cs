namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NHANVIENController : BaseController<NS_NHANVIEN, INS_NHANVIENService>
    {
    private readonly INS_NHANVIENService _NS_NHANVIENService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_NHANVIENController(INS_NHANVIENService NS_NHANVIENService, IWebHostEnvironment WebHostEnvironment) : base(NS_NHANVIENService, WebHostEnvironment)
    {
    _NS_NHANVIENService = NS_NHANVIENService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

