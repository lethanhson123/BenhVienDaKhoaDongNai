namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSYeuCau_QMS_LogController : BaseController<CLSYeuCau_QMS_Log, ICLSYeuCau_QMS_LogService>
    {
    private readonly ICLSYeuCau_QMS_LogService _CLSYeuCau_QMS_LogService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CLSYeuCau_QMS_LogController(ICLSYeuCau_QMS_LogService CLSYeuCau_QMS_LogService, IWebHostEnvironment WebHostEnvironment) : base(CLSYeuCau_QMS_LogService, WebHostEnvironment)
    {
    _CLSYeuCau_QMS_LogService = CLSYeuCau_QMS_LogService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

