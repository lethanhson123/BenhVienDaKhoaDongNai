namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_KeHoachDaoTaoController : BaseController<DM_KeHoachDaoTao, IDM_KeHoachDaoTaoService>
    {
    private readonly IDM_KeHoachDaoTaoService _DM_KeHoachDaoTaoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_KeHoachDaoTaoController(IDM_KeHoachDaoTaoService DM_KeHoachDaoTaoService, IWebHostEnvironment WebHostEnvironment) : base(DM_KeHoachDaoTaoService, WebHostEnvironment)
    {
    _DM_KeHoachDaoTaoService = DM_KeHoachDaoTaoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

