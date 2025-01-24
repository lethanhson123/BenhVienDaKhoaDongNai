namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuSoKetDieuTriController : BaseController<PhieuSoKetDieuTri, IPhieuSoKetDieuTriService>
    {
    private readonly IPhieuSoKetDieuTriService _PhieuSoKetDieuTriService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuSoKetDieuTriController(IPhieuSoKetDieuTriService PhieuSoKetDieuTriService, IWebHostEnvironment WebHostEnvironment) : base(PhieuSoKetDieuTriService, WebHostEnvironment)
    {
    _PhieuSoKetDieuTriService = PhieuSoKetDieuTriService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

