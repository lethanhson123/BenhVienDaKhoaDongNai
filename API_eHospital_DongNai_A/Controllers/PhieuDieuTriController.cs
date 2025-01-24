namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuDieuTriController : BaseController<PhieuDieuTri, IPhieuDieuTriService>
    {
    private readonly IPhieuDieuTriService _PhieuDieuTriService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuDieuTriController(IPhieuDieuTriService PhieuDieuTriService, IWebHostEnvironment WebHostEnvironment) : base(PhieuDieuTriService, WebHostEnvironment)
    {
    _PhieuDieuTriService = PhieuDieuTriService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

