namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_KetQuaMauBenhController : BaseController<DM_KetQuaMauBenh, IDM_KetQuaMauBenhService>
    {
    private readonly IDM_KetQuaMauBenhService _DM_KetQuaMauBenhService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_KetQuaMauBenhController(IDM_KetQuaMauBenhService DM_KetQuaMauBenhService, IWebHostEnvironment WebHostEnvironment) : base(DM_KetQuaMauBenhService, WebHostEnvironment)
    {
    _DM_KetQuaMauBenhService = DM_KetQuaMauBenhService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

