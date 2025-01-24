namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_PhongBanController : BaseController<me_PhongBan, Ime_PhongBanService>
    {
    private readonly Ime_PhongBanService _me_PhongBanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_PhongBanController(Ime_PhongBanService me_PhongBanService, IWebHostEnvironment WebHostEnvironment) : base(me_PhongBanService, WebHostEnvironment)
    {
    _me_PhongBanService = me_PhongBanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

