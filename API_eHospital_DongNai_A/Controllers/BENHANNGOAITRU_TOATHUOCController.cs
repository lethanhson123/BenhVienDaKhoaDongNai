namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BENHANNGOAITRU_TOATHUOCController : BaseController<BENHANNGOAITRU_TOATHUOC, IBENHANNGOAITRU_TOATHUOCService>
    {
    private readonly IBENHANNGOAITRU_TOATHUOCService _BENHANNGOAITRU_TOATHUOCService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BENHANNGOAITRU_TOATHUOCController(IBENHANNGOAITRU_TOATHUOCService BENHANNGOAITRU_TOATHUOCService, IWebHostEnvironment WebHostEnvironment) : base(BENHANNGOAITRU_TOATHUOCService, WebHostEnvironment)
    {
    _BENHANNGOAITRU_TOATHUOCService = BENHANNGOAITRU_TOATHUOCService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

