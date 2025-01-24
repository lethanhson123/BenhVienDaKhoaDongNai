namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuMoPhongChiTietController : BaseController<PhieuMoPhongChiTiet, IPhieuMoPhongChiTietService>
    {
    private readonly IPhieuMoPhongChiTietService _PhieuMoPhongChiTietService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuMoPhongChiTietController(IPhieuMoPhongChiTietService PhieuMoPhongChiTietService, IWebHostEnvironment WebHostEnvironment) : base(PhieuMoPhongChiTietService, WebHostEnvironment)
    {
    _PhieuMoPhongChiTietService = PhieuMoPhongChiTietService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

