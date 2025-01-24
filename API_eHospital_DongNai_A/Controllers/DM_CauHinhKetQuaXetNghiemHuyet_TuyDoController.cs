namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_CauHinhKetQuaXetNghiemHuyet_TuyDoController : BaseController<DM_CauHinhKetQuaXetNghiemHuyet_TuyDo, IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoService>
    {
    private readonly IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoService _DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_CauHinhKetQuaXetNghiemHuyet_TuyDoController(IDM_CauHinhKetQuaXetNghiemHuyet_TuyDoService DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService, IWebHostEnvironment WebHostEnvironment) : base(DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService, WebHostEnvironment)
    {
    _DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService = DM_CauHinhKetQuaXetNghiemHuyet_TuyDoService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

