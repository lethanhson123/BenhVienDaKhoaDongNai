namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_ChuyenKhoaController : BaseController<KhamBenh_ChuyenKhoa, IKhamBenh_ChuyenKhoaService>
    {
    private readonly IKhamBenh_ChuyenKhoaService _KhamBenh_ChuyenKhoaService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public KhamBenh_ChuyenKhoaController(IKhamBenh_ChuyenKhoaService KhamBenh_ChuyenKhoaService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_ChuyenKhoaService, WebHostEnvironment)
    {
    _KhamBenh_ChuyenKhoaService = KhamBenh_ChuyenKhoaService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

