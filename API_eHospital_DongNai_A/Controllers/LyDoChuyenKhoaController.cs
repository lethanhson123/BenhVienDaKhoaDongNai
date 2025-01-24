namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class LyDoChuyenKhoaController : BaseController<LyDoChuyenKhoa, ILyDoChuyenKhoaService>
    {
    private readonly ILyDoChuyenKhoaService _LyDoChuyenKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public LyDoChuyenKhoaController(ILyDoChuyenKhoaService LyDoChuyenKhoaService, IWebHostEnvironment WebHostEnvironment) : base(LyDoChuyenKhoaService, WebHostEnvironment)
    {
    _LyDoChuyenKhoaService = LyDoChuyenKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

