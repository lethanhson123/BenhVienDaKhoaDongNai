namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LichHen_BenhNhanController : BaseController<LichHen_BenhNhan, ILichHen_BenhNhanService>
    {
    private readonly ILichHen_BenhNhanService _LichHen_BenhNhanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LichHen_BenhNhanController(ILichHen_BenhNhanService LichHen_BenhNhanService, IWebHostEnvironment WebHostEnvironment) : base(LichHen_BenhNhanService, WebHostEnvironment)
    {
    _LichHen_BenhNhanService = LichHen_BenhNhanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

