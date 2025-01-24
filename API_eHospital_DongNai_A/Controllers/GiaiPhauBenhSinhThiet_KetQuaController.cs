namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GiaiPhauBenhSinhThiet_KetQuaController : BaseController<GiaiPhauBenhSinhThiet_KetQua, IGiaiPhauBenhSinhThiet_KetQuaService>
    {
    private readonly IGiaiPhauBenhSinhThiet_KetQuaService _GiaiPhauBenhSinhThiet_KetQuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public GiaiPhauBenhSinhThiet_KetQuaController(IGiaiPhauBenhSinhThiet_KetQuaService GiaiPhauBenhSinhThiet_KetQuaService, IWebHostEnvironment WebHostEnvironment) : base(GiaiPhauBenhSinhThiet_KetQuaService, WebHostEnvironment)
    {
    _GiaiPhauBenhSinhThiet_KetQuaService = GiaiPhauBenhSinhThiet_KetQuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

