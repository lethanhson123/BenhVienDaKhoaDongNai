namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_CDT_PhanLoaiKetQuaController : BaseController<DM_CDT_PhanLoaiKetQua, IDM_CDT_PhanLoaiKetQuaService>
    {
    private readonly IDM_CDT_PhanLoaiKetQuaService _DM_CDT_PhanLoaiKetQuaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_CDT_PhanLoaiKetQuaController(IDM_CDT_PhanLoaiKetQuaService DM_CDT_PhanLoaiKetQuaService, IWebHostEnvironment WebHostEnvironment) : base(DM_CDT_PhanLoaiKetQuaService, WebHostEnvironment)
    {
    _DM_CDT_PhanLoaiKetQuaService = DM_CDT_PhanLoaiKetQuaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

