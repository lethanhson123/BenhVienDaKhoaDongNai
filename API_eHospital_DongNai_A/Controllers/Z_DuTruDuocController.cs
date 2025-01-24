namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Z_DuTruDuocController : BaseController<Z_DuTruDuoc, IZ_DuTruDuocService>
    {
    private readonly IZ_DuTruDuocService _Z_DuTruDuocService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Z_DuTruDuocController(IZ_DuTruDuocService Z_DuTruDuocService, IWebHostEnvironment WebHostEnvironment) : base(Z_DuTruDuocService, WebHostEnvironment)
    {
    _Z_DuTruDuocService = Z_DuTruDuocService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

