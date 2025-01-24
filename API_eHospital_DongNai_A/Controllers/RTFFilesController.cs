namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class RTFFilesController : BaseController<RTFFiles, IRTFFilesService>
    {
    private readonly IRTFFilesService _RTFFilesService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public RTFFilesController(IRTFFilesService RTFFilesService, IWebHostEnvironment WebHostEnvironment) : base(RTFFilesService, WebHostEnvironment)
    {
    _RTFFilesService = RTFFilesService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

