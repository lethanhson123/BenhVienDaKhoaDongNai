namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhieuXaTriController : BaseController<PhieuXaTri, IPhieuXaTriService>
    {
    private readonly IPhieuXaTriService _PhieuXaTriService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhieuXaTriController(IPhieuXaTriService PhieuXaTriService, IWebHostEnvironment WebHostEnvironment) : base(PhieuXaTriService, WebHostEnvironment)
    {
    _PhieuXaTriService = PhieuXaTriService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

