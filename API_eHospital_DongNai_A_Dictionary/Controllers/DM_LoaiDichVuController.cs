namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_LoaiDichVuController : BaseController<DM_LoaiDichVu, IDM_LoaiDichVuService>
    {
    private readonly IDM_LoaiDichVuService _DM_LoaiDichVuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_LoaiDichVuController(IDM_LoaiDichVuService DM_LoaiDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DM_LoaiDichVuService, WebHostEnvironment)
    {
    _DM_LoaiDichVuService = DM_LoaiDichVuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

