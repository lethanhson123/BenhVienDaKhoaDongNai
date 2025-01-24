namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_LichHenChiTietController : BaseController<me_LichHenChiTiet, Ime_LichHenChiTietService>
    {
    private readonly Ime_LichHenChiTietService _me_LichHenChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_LichHenChiTietController(Ime_LichHenChiTietService me_LichHenChiTietService, IWebHostEnvironment WebHostEnvironment) : base(me_LichHenChiTietService, WebHostEnvironment)
    {
    _me_LichHenChiTietService = me_LichHenChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

