namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BENHANNGOAITRU_KHAMBENHController : BaseController<BENHANNGOAITRU_KHAMBENH, IBENHANNGOAITRU_KHAMBENHService>
    {
    private readonly IBENHANNGOAITRU_KHAMBENHService _BENHANNGOAITRU_KHAMBENHService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BENHANNGOAITRU_KHAMBENHController(IBENHANNGOAITRU_KHAMBENHService BENHANNGOAITRU_KHAMBENHService, IWebHostEnvironment WebHostEnvironment) : base(BENHANNGOAITRU_KHAMBENHService, WebHostEnvironment)
    {
    _BENHANNGOAITRU_KHAMBENHService = BENHANNGOAITRU_KHAMBENHService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

