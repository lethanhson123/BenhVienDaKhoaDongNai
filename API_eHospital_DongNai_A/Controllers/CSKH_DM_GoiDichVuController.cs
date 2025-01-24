namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CSKH_DM_GoiDichVuController : BaseController<CSKH_DM_GoiDichVu, ICSKH_DM_GoiDichVuService>
    {
    private readonly ICSKH_DM_GoiDichVuService _CSKH_DM_GoiDichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CSKH_DM_GoiDichVuController(ICSKH_DM_GoiDichVuService CSKH_DM_GoiDichVuService, IWebHostEnvironment WebHostEnvironment) : base(CSKH_DM_GoiDichVuService, WebHostEnvironment)
    {
    _CSKH_DM_GoiDichVuService = CSKH_DM_GoiDichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

