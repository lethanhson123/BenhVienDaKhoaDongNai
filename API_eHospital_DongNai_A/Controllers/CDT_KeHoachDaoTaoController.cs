namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CDT_KeHoachDaoTaoController : BaseController<CDT_KeHoachDaoTao, ICDT_KeHoachDaoTaoService>
    {
    private readonly ICDT_KeHoachDaoTaoService _CDT_KeHoachDaoTaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CDT_KeHoachDaoTaoController(ICDT_KeHoachDaoTaoService CDT_KeHoachDaoTaoService, IWebHostEnvironment WebHostEnvironment) : base(CDT_KeHoachDaoTaoService, WebHostEnvironment)
    {
    _CDT_KeHoachDaoTaoService = CDT_KeHoachDaoTaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

