namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChuyenVienController : BaseController<ChuyenVien, IChuyenVienService>
    {
    private readonly IChuyenVienService _ChuyenVienService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ChuyenVienController(IChuyenVienService ChuyenVienService, IWebHostEnvironment WebHostEnvironment) : base(ChuyenVienService, WebHostEnvironment)
    {
    _ChuyenVienService = ChuyenVienService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

