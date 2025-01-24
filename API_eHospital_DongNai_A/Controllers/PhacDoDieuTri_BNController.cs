namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class PhacDoDieuTri_BNController : BaseController<PhacDoDieuTri_BN, IPhacDoDieuTri_BNService>
    {
    private readonly IPhacDoDieuTri_BNService _PhacDoDieuTri_BNService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public PhacDoDieuTri_BNController(IPhacDoDieuTri_BNService PhacDoDieuTri_BNService, IWebHostEnvironment WebHostEnvironment) : base(PhacDoDieuTri_BNService, WebHostEnvironment)
    {
    _PhacDoDieuTri_BNService = PhacDoDieuTri_BNService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

