namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class MauTinSMSController : BaseController<MauTinSMS, IMauTinSMSService>
    {
    private readonly IMauTinSMSService _MauTinSMSService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public MauTinSMSController(IMauTinSMSService MauTinSMSService, IWebHostEnvironment WebHostEnvironment) : base(MauTinSMSService, WebHostEnvironment)
    {
    _MauTinSMSService = MauTinSMSService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

