namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_LoaiGiaController : BaseController<DM_LoaiGia, IDM_LoaiGiaService>
    {
    private readonly IDM_LoaiGiaService _DM_LoaiGiaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_LoaiGiaController(IDM_LoaiGiaService DM_LoaiGiaService, IWebHostEnvironment WebHostEnvironment) : base(DM_LoaiGiaService, WebHostEnvironment)
    {
    _DM_LoaiGiaService = DM_LoaiGiaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

