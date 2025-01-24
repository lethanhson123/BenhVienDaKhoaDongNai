namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_LichHenController : BaseController<me_LichHen, Ime_LichHenService>
    {
    private readonly Ime_LichHenService _me_LichHenService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_LichHenController(Ime_LichHenService me_LichHenService, IWebHostEnvironment WebHostEnvironment) : base(me_LichHenService, WebHostEnvironment)
    {
    _me_LichHenService = me_LichHenService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

