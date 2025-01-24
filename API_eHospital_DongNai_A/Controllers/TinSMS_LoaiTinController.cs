namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TinSMS_LoaiTinController : BaseController<TinSMS_LoaiTin, ITinSMS_LoaiTinService>
    {
    private readonly ITinSMS_LoaiTinService _TinSMS_LoaiTinService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TinSMS_LoaiTinController(ITinSMS_LoaiTinService TinSMS_LoaiTinService, IWebHostEnvironment WebHostEnvironment) : base(TinSMS_LoaiTinService, WebHostEnvironment)
    {
    _TinSMS_LoaiTinService = TinSMS_LoaiTinService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

