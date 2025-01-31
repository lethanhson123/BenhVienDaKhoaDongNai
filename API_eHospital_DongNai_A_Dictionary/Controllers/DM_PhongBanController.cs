namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_PhongBanController : BaseController<DM_PhongBan, IDM_PhongBanService>
    {
    private readonly IDM_PhongBanService _DM_PhongBanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_PhongBanController(IDM_PhongBanService DM_PhongBanService, IWebHostEnvironment WebHostEnvironment) : base(DM_PhongBanService, WebHostEnvironment)
    {
    _DM_PhongBanService = DM_PhongBanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

