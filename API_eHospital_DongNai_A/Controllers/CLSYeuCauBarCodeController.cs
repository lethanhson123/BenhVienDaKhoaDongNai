namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSYeuCauBarCodeController : BaseController<CLSYeuCauBarCode, ICLSYeuCauBarCodeService>
    {
    private readonly ICLSYeuCauBarCodeService _CLSYeuCauBarCodeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSYeuCauBarCodeController(ICLSYeuCauBarCodeService CLSYeuCauBarCodeService, IWebHostEnvironment WebHostEnvironment) : base(CLSYeuCauBarCodeService, WebHostEnvironment)
    {
    _CLSYeuCauBarCodeService = CLSYeuCauBarCodeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

