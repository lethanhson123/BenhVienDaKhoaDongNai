namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuLinhDuocChiTietController : BaseController<PhieuLinhDuocChiTiet, IPhieuLinhDuocChiTietService>
    {
    private readonly IPhieuLinhDuocChiTietService _PhieuLinhDuocChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuLinhDuocChiTietController(IPhieuLinhDuocChiTietService PhieuLinhDuocChiTietService, IWebHostEnvironment WebHostEnvironment) : base(PhieuLinhDuocChiTietService, WebHostEnvironment)
    {
    _PhieuLinhDuocChiTietService = PhieuLinhDuocChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

