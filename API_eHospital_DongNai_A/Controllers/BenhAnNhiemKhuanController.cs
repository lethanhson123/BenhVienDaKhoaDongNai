namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnNhiemKhuanController : BaseController<BenhAnNhiemKhuan, IBenhAnNhiemKhuanService>
    {
    private readonly IBenhAnNhiemKhuanService _BenhAnNhiemKhuanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnNhiemKhuanController(IBenhAnNhiemKhuanService BenhAnNhiemKhuanService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnNhiemKhuanService, WebHostEnvironment)
    {
    _BenhAnNhiemKhuanService = BenhAnNhiemKhuanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

